namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.headingTrackBar = new System.Windows.Forms.TrackBar();
            this.headingLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.velocidadLbl = new System.Windows.Forms.Label();
            this.velocidadTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bateriaLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.headLbl = new System.Windows.Forms.Label();
            this.longitudLbl = new System.Windows.Forms.Label();
            this.latitudLbl = new System.Windows.Forms.Label();
            this.altitudLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alturatrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.but_connect = new System.Windows.Forms.Button();
            this.alturalbl = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.despegarBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.latmovBox = new System.Windows.Forms.TextBox();
            this.longmovBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.alturamovBox = new System.Windows.Forms.TextBox();
            this.irPuntoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocidadTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alturatrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Heading";
            // 
            // headingTrackBar
            // 
            this.headingTrackBar.Location = new System.Drawing.Point(455, 219);
            this.headingTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.headingTrackBar.Maximum = 360;
            this.headingTrackBar.Name = "headingTrackBar";
            this.headingTrackBar.Size = new System.Drawing.Size(241, 56);
            this.headingTrackBar.TabIndex = 34;
            this.headingTrackBar.Scroll += new System.EventHandler(this.headingTrackBar_Scroll);
            this.headingTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headingTrackBar_MouseUp);
            // 
            // headingLbl
            // 
            this.headingLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.ForeColor = System.Drawing.Color.Red;
            this.headingLbl.Location = new System.Drawing.Point(443, 174);
            this.headingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(65, 24);
            this.headingLbl.TabIndex = 35;
            this.headingLbl.Text = "0";
            this.headingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(518, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Velocidad";
            // 
            // velocidadLbl
            // 
            this.velocidadLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.velocidadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocidadLbl.ForeColor = System.Drawing.Color.Red;
            this.velocidadLbl.Location = new System.Drawing.Point(440, 78);
            this.velocidadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.velocidadLbl.Name = "velocidadLbl";
            this.velocidadLbl.Size = new System.Drawing.Size(65, 29);
            this.velocidadLbl.TabIndex = 37;
            this.velocidadLbl.Text = "1";
            this.velocidadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velocidadTrackBar
            // 
            this.velocidadTrackBar.Location = new System.Drawing.Point(455, 118);
            this.velocidadTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.velocidadTrackBar.Minimum = 1;
            this.velocidadTrackBar.Name = "velocidadTrackBar";
            this.velocidadTrackBar.Size = new System.Drawing.Size(241, 56);
            this.velocidadTrackBar.TabIndex = 36;
            this.velocidadTrackBar.Value = 1;
            this.velocidadTrackBar.Scroll += new System.EventHandler(this.velocidadTrackBar_Scroll);
            this.velocidadTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.velocidadTrackBar_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bateriaLbl);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.headLbl);
            this.groupBox4.Controls.Add(this.longitudLbl);
            this.groupBox4.Controls.Add(this.latitudLbl);
            this.groupBox4.Controls.Add(this.altitudLbl);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(552, 283);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(559, 212);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telemetría";
            // 
            // bateriaLbl
            // 
            this.bateriaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bateriaLbl.Location = new System.Drawing.Point(459, 107);
            this.bateriaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bateriaLbl.Name = "bateriaLbl";
            this.bateriaLbl.Size = new System.Drawing.Size(83, 36);
            this.bateriaLbl.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Bateria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Heading";
            // 
            // headLbl
            // 
            this.headLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headLbl.Location = new System.Drawing.Point(280, 155);
            this.headLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(83, 36);
            this.headLbl.TabIndex = 10;
            // 
            // longitudLbl
            // 
            this.longitudLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longitudLbl.Location = new System.Drawing.Point(104, 154);
            this.longitudLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longitudLbl.Name = "longitudLbl";
            this.longitudLbl.Size = new System.Drawing.Size(74, 38);
            this.longitudLbl.TabIndex = 8;
            // 
            // latitudLbl
            // 
            this.latitudLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latitudLbl.Location = new System.Drawing.Point(104, 105);
            this.latitudLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latitudLbl.Name = "latitudLbl";
            this.latitudLbl.Size = new System.Drawing.Size(74, 38);
            this.latitudLbl.TabIndex = 7;
            // 
            // altitudLbl
            // 
            this.altitudLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.altitudLbl.Location = new System.Drawing.Point(280, 106);
            this.altitudLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.altitudLbl.Name = "altitudLbl";
            this.altitudLbl.Size = new System.Drawing.Size(83, 36);
            this.altitudLbl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Longitud";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(292, 47);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(145, 32);
            this.button22.TabIndex = 1;
            this.button22.Text = "Parar";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.detenerTelemetriaBtn_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(116, 47);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(156, 32);
            this.button23.TabIndex = 0;
            this.button23.Text = "Iniciar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.enviarTelemetriaBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.irPuntoBtn);
            this.groupBox2.Controls.Add(this.alturamovBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.longmovBox);
            this.groupBox2.Controls.Add(this.latmovBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(488, 277);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 18;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(183, 188);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 59);
            this.button17.TabIndex = 8;
            this.button17.Tag = "SouthEast";
            this.button17.Text = "SE";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button16.Location = new System.Drawing.Point(104, 188);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(71, 59);
            this.button16.TabIndex = 7;
            this.button16.Tag = "South";
            this.button16.Text = "S";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(23, 188);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 59);
            this.button15.TabIndex = 6;
            this.button15.Tag = "SouthWest";
            this.button15.Text = "SW";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(185, 126);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 55);
            this.button14.TabIndex = 5;
            this.button14.Tag = "East";
            this.button14.Text = "E";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(104, 124);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 57);
            this.button13.TabIndex = 4;
            this.button13.Tag = "Stop";
            this.button13.Text = "Stop";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(23, 124);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 57);
            this.button12.TabIndex = 3;
            this.button12.Tag = "West";
            this.button12.Text = "W";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(185, 57);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 60);
            this.button11.TabIndex = 2;
            this.button11.Tag = "NorthEast";
            this.button11.Text = "NE";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(104, 57);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 60);
            this.button10.TabIndex = 1;
            this.button10.Tag = "North";
            this.button10.Text = "N";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(23, 57);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 59);
            this.button9.TabIndex = 0;
            this.button9.Tag = "NorthWest";
            this.button9.Text = "NW";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.alturatrackBar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.but_connect);
            this.groupBox1.Controls.Add(this.alturalbl);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.despegarBtn);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 204);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // alturatrackBar
            // 
            this.alturatrackBar.Location = new System.Drawing.Point(150, 82);
            this.alturatrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.alturatrackBar.Minimum = 1;
            this.alturatrackBar.Name = "alturatrackBar";
            this.alturatrackBar.Size = new System.Drawing.Size(241, 56);
            this.alturatrackBar.TabIndex = 40;
            this.alturatrackBar.Value = 1;
            this.alturatrackBar.Scroll += new System.EventHandler(this.alturatrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Altura";
            // 
            // but_connect
            // 
            this.but_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.but_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_connect.Location = new System.Drawing.Point(8, 37);
            this.but_connect.Margin = new System.Windows.Forms.Padding(4);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(383, 36);
            this.but_connect.TabIndex = 2;
            this.but_connect.Text = "Connectar";
            this.but_connect.UseVisualStyleBackColor = false;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // alturalbl
            // 
            this.alturalbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alturalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturalbl.ForeColor = System.Drawing.Color.Red;
            this.alturalbl.Location = new System.Drawing.Point(45, 77);
            this.alturalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alturalbl.Name = "alturalbl";
            this.alturalbl.Size = new System.Drawing.Size(65, 29);
            this.alturalbl.TabIndex = 41;
            this.alturalbl.Text = "1";
            this.alturalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 146);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 38);
            this.button7.TabIndex = 13;
            this.button7.Text = "Aterrizar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.aterrizarBtn_Click);
            // 
            // despegarBtn
            // 
            this.despegarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.despegarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despegarBtn.Location = new System.Drawing.Point(283, 146);
            this.despegarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.despegarBtn.Name = "despegarBtn";
            this.despegarBtn.Size = new System.Drawing.Size(117, 38);
            this.despegarBtn.TabIndex = 5;
            this.despegarBtn.Text = "Despegar";
            this.despegarBtn.UseVisualStyleBackColor = false;
            this.despegarBtn.Click += new System.EventHandler(this.but_takeoff_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 146);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "RTL";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.RTLBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Latitud";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "Longitud";
            // 
            // latmovBox
            // 
            this.latmovBox.Location = new System.Drawing.Point(364, 99);
            this.latmovBox.Name = "latmovBox";
            this.latmovBox.Size = new System.Drawing.Size(100, 37);
            this.latmovBox.TabIndex = 21;
            // 
            // longmovBox
            // 
            this.longmovBox.Location = new System.Drawing.Point(364, 147);
            this.longmovBox.Name = "longmovBox";
            this.longmovBox.Size = new System.Drawing.Size(100, 37);
            this.longmovBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "Altitud";
            // 
            // alturamovBox
            // 
            this.alturamovBox.Location = new System.Drawing.Point(361, 196);
            this.alturamovBox.Name = "alturamovBox";
            this.alturamovBox.Size = new System.Drawing.Size(100, 37);
            this.alturamovBox.TabIndex = 24;
            // 
            // irPuntoBtn
            // 
            this.irPuntoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.irPuntoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irPuntoBtn.Location = new System.Drawing.Point(263, 57);
            this.irPuntoBtn.Name = "irPuntoBtn";
            this.irPuntoBtn.Size = new System.Drawing.Size(198, 37);
            this.irPuntoBtn.TabIndex = 25;
            this.irPuntoBtn.Text = "Ir al punto";
            this.irPuntoBtn.UseVisualStyleBackColor = false;
            this.irPuntoBtn.Click += new System.EventHandler(this.irPuntoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.headingTrackBar);
            this.Controls.Add(this.headingLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.velocidadLbl);
            this.Controls.Add(this.velocidadTrackBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocidadTrackBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alturatrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar headingTrackBar;
        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label velocidadLbl;
        private System.Windows.Forms.TrackBar velocidadTrackBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label headLbl;
        private System.Windows.Forms.Label longitudLbl;
        private System.Windows.Forms.Label latitudLbl;
        private System.Windows.Forms.Label altitudLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button despegarBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TrackBar alturatrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label alturalbl;
        private System.Windows.Forms.Label bateriaLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button irPuntoBtn;
        private System.Windows.Forms.TextBox alturamovBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox longmovBox;
        private System.Windows.Forms.TextBox latmovBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}

