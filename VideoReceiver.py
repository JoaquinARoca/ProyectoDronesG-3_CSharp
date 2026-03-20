import asyncio
import threading
import cv2
import numpy as np
from http.server import BaseHTTPRequestHandler, HTTPServer
from aiortc import RTCPeerConnection, RTCSessionDescription, MediaStreamTrack
from aiortc.contrib.signaling import TcpSocketSignaling

latest_frame = None
frame_lock = threading.Lock()

# ── Servidor MJPEG para C# ──────────────────────────────────
class MJPEGHandler(BaseHTTPRequestHandler):
    def do_GET(self):
        self.send_response(200)
        self.send_header('Content-Type', 'multipart/x-mixed-replace; boundary=frame')
        self.end_headers()
        while True:
            with frame_lock:
                frame = latest_frame
            if frame is not None:
                _, jpeg = cv2.imencode('.jpg', frame,
                    [cv2.IMWRITE_JPEG_QUALITY, 50])  # ✅ bajado de 70 a 50
                # ✅ También reduce resolución para menos datos
                data = jpeg.tobytes()
                try:
                    self.wfile.write(b'--frame\r\nContent-Type: image/jpeg\r\n\r\n')
                    self.wfile.write(data)
                    self.wfile.write(b'\r\n')
                except:
                    break
            else:
                import time; time.sleep(0.03)

def start_mjpeg_server():
    server = HTTPServer(('localhost', 8888), MJPEGHandler)
    server.serve_forever()

# ── Receptor WebRTC ─────────────────────────────────────────
class VideoReceiver:
    async def handle_track(self, track):
        global latest_frame
        while True:
            try:
                frame = await asyncio.wait_for(track.recv(), timeout=5.0)
                img = frame.to_ndarray(format="bgr24")
                img = cv2.flip(img, 1)
                img = cv2.resize(img, (640, 360))  # ✅ resolución fija baja
                with frame_lock:
                    latest_frame = img
            except asyncio.TimeoutError:
                print("Timeout esperando frame")
            except Exception as ex:
                print(f"Error: {ex}");
                break

async def run():
    IP_server = "localhost"   # cambia a la IP del CameraService si está en otro PC
    signaling = TcpSocketSignaling(IP_server, 9999)
    pc = RTCPeerConnection()
    receiver = VideoReceiver()

    @pc.on("track")
    def on_track(track):
        if isinstance(track, MediaStreamTrack):
            asyncio.ensure_future(receiver.handle_track(track))

    await signaling.connect()
    offer = await signaling.receive()
    await pc.setRemoteDescription(offer)
    answer = await pc.createAnswer()
    await pc.setLocalDescription(answer)
    await signaling.send(pc.localDescription)
    print("Stream WebRTC recibido. MJPEG en http://localhost:8888")
    await asyncio.sleep(3600)

if __name__ == "__main__":
    # Arranca el servidor MJPEG en un hilo
    threading.Thread(target=start_mjpeg_server, daemon=True).start()
    asyncio.run(run())