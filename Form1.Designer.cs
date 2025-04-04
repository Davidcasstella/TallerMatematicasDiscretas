namespace MatematicasDiscretastaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code


        private SistemaDomotico sistemaDomotico;
        public class SistemaDomotico
        {
            public List<Habitacion> Habitaciones { get; set; }
            public DateTime HoraActual { get; set; }

            public SistemaDomotico()
            {
                Habitaciones = new List<Habitacion>
        {
            new Habitacion("Comedor"),
            new Habitacion("Cocina"),
            new Habitacion("Sala"),
            new Habitacion("Habitación")
        };
                HoraActual = DateTime.Now;
            }

            public void ActualizarSistema()
            {
                // Lógica para actualizar el sistema
            }

            public void ActualizarHora()
            {
                // Lógica para actualizar la hora
            }
        }




        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()

        {
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            ilbhora = new Label();
            lblfecha = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(81, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(211, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBoxSensorPresenciaComedor";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(81, 280);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(198, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBoxSensorPresenciaCocina";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(604, 35);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(182, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBoxSensorPresenciaSala";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(604, 280);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(219, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBoxSensorPresenciaHabitacion";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(81, 81);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(207, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBoxSensorAperturaComedor";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(81, 324);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(178, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "checkBoxSensorAperturaSala";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(604, 324);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(215, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "checkBoxSensorAperturaHabitacion";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(604, 71);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(194, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "checkBoxSensorAperturaCocina";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(81, 116);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 8;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(604, 116);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(104, 45);
            trackBar2.TabIndex = 9;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(81, 365);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(104, 45);
            trackBar3.TabIndex = 10;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(604, 365);
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(104, 45);
            trackBar4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 156);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 12;
            label1.Text = "labelIluminacionComedor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 156);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 13;
            label2.Text = "labelIluminacionCocina";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 398);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 14;
            label3.Text = "labelIluminacionSala";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 398);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 15;
            label4.Text = "labelIluminacionHabitacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 176);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 16;
            label5.Text = "labelAireComedor\n\n";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(609, 184);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 17;
            label6.Text = "labelAireCocina";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 430);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 18;
            label7.Text = "labelAireSala";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(609, 430);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 19;
            label8.Text = "labelAireHabitacion";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += timer1_Tick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 20;
            label9.Text = "label9";
            // 
            // ilbhora
            // 
            ilbhora.AutoSize = true;
            ilbhora.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ilbhora.ForeColor = Color.DarkTurquoise;
            ilbhora.Location = new Point(417, 52);
            ilbhora.Name = "ilbhora";
            ilbhora.Size = new Size(119, 40);
            ilbhora.TabIndex = 21;
            ilbhora.Text = "label10";
            ilbhora.Click += label10_Click;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblfecha.ForeColor = Color.DarkSlateGray;
            lblfecha.Location = new Point(417, 104);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(119, 40);
            lblfecha.TabIndex = 22;
            lblfecha.Text = "label10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 501);
            Controls.Add(lblfecha);
            Controls.Add(ilbhora);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        private void checkBox1_CheckedChanged1(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[0]; // Comedor
            habitacionSeleccionada.SensorPresencia = checkBox1.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox2_CheckedChanged2(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[1]; // Cocina
            habitacionSeleccionada.SensorPresencia = checkBox2.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[2]; // Sala
            habitacionSeleccionada.SensorPresencia = checkBox3.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[3]; // Habitación
            habitacionSeleccionada.SensorPresencia = checkBox4.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[0]; // Comedor
            habitacionSeleccionada.SensorApertura = checkBox5.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[2]; // Sala
            habitacionSeleccionada.SensorApertura = checkBox6.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[3]; // Habitación
            habitacionSeleccionada.SensorApertura = checkBox7.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[1]; // Cocina
            habitacionSeleccionada.SensorApertura = checkBox8.Checked;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[0]; // Comedor
            habitacionSeleccionada.Temperatura = trackBar1.Value;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[1]; // Cocina
            habitacionSeleccionada.Temperatura = trackBar2.Value;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[2]; // Sala
            habitacionSeleccionada.Temperatura = trackBar3.Value;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            var habitacionSeleccionada = sistemaDomotico.Habitaciones[3]; // Habitación
            habitacionSeleccionada.Temperatura = trackBar4.Value;
            sistemaDomotico.ActualizarSistema();
            ActualizarInterfaz();
        }
        private void InitializeComponent1()
        {
            // Código generado automáticamente para la creación del formulario y sus controles
            // Asegúrate de que los eventos estén correctamente conectados
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged1);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
        }
        private void ActualizarInterfaz()
        {
            // Actualiza los CheckBox para los sensores de presencia
            checkBox1.Checked = sistemaDomotico.Habitaciones[0].SensorPresencia;
            checkBox2.Checked = sistemaDomotico.Habitaciones[1].SensorPresencia;
            checkBox3.Checked = sistemaDomotico.Habitaciones[2].SensorPresencia;
            checkBox4.Checked = sistemaDomotico.Habitaciones[3].SensorPresencia;

            // Actualiza los CheckBox para los sensores de apertura
            checkBox5.Checked = sistemaDomotico.Habitaciones[0].SensorApertura;
            checkBox6.Checked = sistemaDomotico.Habitaciones[2].SensorApertura;
            checkBox7.Checked = sistemaDomotico.Habitaciones[3].SensorApertura;
            checkBox8.Checked = sistemaDomotico.Habitaciones[1].SensorApertura;

            // Actualiza los Labels para los actuadores (Iluminación)
            label1.Text = sistemaDomotico.Habitaciones[0].Iluminacion ? "ON" : "OFF";
            label2.Text = sistemaDomotico.Habitaciones[1].Iluminacion ? "ON" : "OFF";
            label3.Text = sistemaDomotico.Habitaciones[2].Iluminacion ? "ON" : "OFF";
            label4.Text = sistemaDomotico.Habitaciones[3].Iluminacion ? "ON" : "OFF";

            // Actualiza los Labels para los actuadores (Aire acondicionado)
            label5.Text = sistemaDomotico.Habitaciones[0].AireAcondicionado ? "ON" : "OFF";
            label6.Text = sistemaDomotico.Habitaciones[1].AireAcondicionado ? "ON" : "OFF";
            label7.Text = sistemaDomotico.Habitaciones[2].AireAcondicionado ? "ON" : "OFF";
            label8.Text = sistemaDomotico.Habitaciones[3].AireAcondicionado ? "ON" : "OFF";
        }
        private System.Windows.Forms.Timer horafecha;
        private Label label9;
        private Label ilbhora;
        private Label lblfecha;
    }
}
