namespace MematicasDis
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Hora = new System.Windows.Forms.Timer(components);
            Lahora = new Label();
            ComedorTemp = new TrackBar();
            HabitacionTemp = new TrackBar();
            SalaTemp = new TrackBar();
            CocinaTemp = new TrackBar();
            PuertaComedor = new CheckBox();
            PuertaHabitacion = new CheckBox();
            PuertaCocina = new CheckBox();
            PuertaSala = new CheckBox();
            btnBombilloComedor = new Button();
            btnBombilloHabitacion = new Button();
            btnBombilloCocina = new Button();
            btnBombilloSala = new Button();
            VentanaComedor = new CheckBox();
            VentanaHabitacion = new CheckBox();
            VentanaCocina = new CheckBox();
            VentanaSala = new CheckBox();
            label1 = new Label();
            aireAcondicionadoComedor = new Button();
            aireAcondicionadoHabitacion = new Button();
            aireAcondicionadoCocina = new Button();
            aireAcondicionadoSala = new Button();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            OperacionesLogicas = new Button();
            PuertaPrincipal = new CheckBox();
            SensorHabitacionPresencia = new CheckBox();
            SensorCocinaaPresencia = new CheckBox();
            SensorSalaPresencia = new CheckBox();
            SensorComedorPresencia = new CheckBox();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ComedorTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HabitacionTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CocinaTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Hora
            // 
            Hora.Enabled = true;
            Hora.Tick += Hora_Tick;
            // 
            // Lahora
            // 
            Lahora.AutoSize = true;
            Lahora.BackColor = Color.Turquoise;
            Lahora.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lahora.Location = new Point(381, 9);
            Lahora.Name = "Lahora";
            Lahora.Size = new Size(142, 70);
            Lahora.TabIndex = 0;
            Lahora.Text = "Reloj";
            Lahora.Click += Lahora_Click;
            // 
            // ComedorTemp
            // 
            ComedorTemp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ComedorTemp.Cursor = Cursors.Cross;
            ComedorTemp.Location = new Point(12, 47);
            ComedorTemp.Maximum = 50;
            ComedorTemp.Name = "ComedorTemp";
            ComedorTemp.Orientation = Orientation.Vertical;
            ComedorTemp.Size = new Size(69, 148);
            ComedorTemp.TabIndex = 1;
            ComedorTemp.Scroll += ComedorTemp_Scroll;
            // 
            // HabitacionTemp
            // 
            HabitacionTemp.Location = new Point(877, 47);
            HabitacionTemp.Maximum = 50;
            HabitacionTemp.Name = "HabitacionTemp";
            HabitacionTemp.Orientation = Orientation.Vertical;
            HabitacionTemp.Size = new Size(69, 156);
            HabitacionTemp.TabIndex = 2;
            HabitacionTemp.Scroll += HabitacionTemp_Scroll;
            // 
            // SalaTemp
            // 
            SalaTemp.Location = new Point(876, 387);
            SalaTemp.Maximum = 50;
            SalaTemp.Name = "SalaTemp";
            SalaTemp.Orientation = Orientation.Vertical;
            SalaTemp.Size = new Size(69, 156);
            SalaTemp.TabIndex = 3;
            SalaTemp.Scroll += SalaTemp_Scroll;
            // 
            // CocinaTemp
            // 
            CocinaTemp.Location = new Point(16, 400);
            CocinaTemp.Maximum = 50;
            CocinaTemp.Name = "CocinaTemp";
            CocinaTemp.Orientation = Orientation.Vertical;
            CocinaTemp.Size = new Size(69, 156);
            CocinaTemp.TabIndex = 4;
            CocinaTemp.Scroll += CocinaTemp_Scroll;
            // 
            // PuertaComedor
            // 
            PuertaComedor.AutoSize = true;
            PuertaComedor.BackColor = Color.FromArgb(192, 64, 0);
            PuertaComedor.Location = new Point(304, 91);
            PuertaComedor.Name = "PuertaComedor";
            PuertaComedor.Size = new Size(163, 29);
            PuertaComedor.TabIndex = 5;
            PuertaComedor.Text = "PuertaComedor";
            PuertaComedor.UseVisualStyleBackColor = false;
            PuertaComedor.CheckedChanged += PuertaComedor_CheckedChanged;
            // 
            // PuertaHabitacion
            // 
            PuertaHabitacion.AutoSize = true;
            PuertaHabitacion.BackColor = Color.FromArgb(192, 64, 0);
            PuertaHabitacion.Location = new Point(460, 374);
            PuertaHabitacion.Name = "PuertaHabitacion";
            PuertaHabitacion.Size = new Size(173, 29);
            PuertaHabitacion.TabIndex = 6;
            PuertaHabitacion.Text = "PuertaHabitacion";
            PuertaHabitacion.UseVisualStyleBackColor = false;
            PuertaHabitacion.CheckedChanged += PuertaHabitacion_CheckedChanged;
            // 
            // PuertaCocina
            // 
            PuertaCocina.AutoSize = true;
            PuertaCocina.BackColor = Color.FromArgb(192, 64, 0);
            PuertaCocina.Location = new Point(313, 374);
            PuertaCocina.Name = "PuertaCocina";
            PuertaCocina.Size = new Size(141, 29);
            PuertaCocina.TabIndex = 7;
            PuertaCocina.Text = "PuertaCocina";
            PuertaCocina.UseVisualStyleBackColor = false;
            PuertaCocina.CheckedChanged += PuertaCocina_CheckedChanged;
            // 
            // PuertaSala
            // 
            PuertaSala.AutoSize = true;
            PuertaSala.BackColor = Color.FromArgb(192, 64, 0);
            PuertaSala.Location = new Point(474, 596);
            PuertaSala.Name = "PuertaSala";
            PuertaSala.Size = new Size(120, 29);
            PuertaSala.TabIndex = 8;
            PuertaSala.Text = "PuertaSala";
            PuertaSala.UseVisualStyleBackColor = false;
            PuertaSala.CheckedChanged += PuertaSala_CheckedChanged;
            // 
            // btnBombilloComedor
            // 
            btnBombilloComedor.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloComedor.Location = new Point(371, 191);
            btnBombilloComedor.Name = "btnBombilloComedor";
            btnBombilloComedor.Size = new Size(61, 92);
            btnBombilloComedor.TabIndex = 9;
            btnBombilloComedor.Text = "BombilloComedor";
            btnBombilloComedor.UseVisualStyleBackColor = true;
            btnBombilloComedor.Click += btnBombillo_Click;
            // 
            // btnBombilloHabitacion
            // 
            btnBombilloHabitacion.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloHabitacion.Location = new Point(474, 191);
            btnBombilloHabitacion.Name = "btnBombilloHabitacion";
            btnBombilloHabitacion.Size = new Size(61, 92);
            btnBombilloHabitacion.TabIndex = 10;
            btnBombilloHabitacion.Text = "BombilloHabitacion";
            btnBombilloHabitacion.UseVisualStyleBackColor = true;
            btnBombilloHabitacion.Click += btnBombilloHabitacion_Click;
            // 
            // btnBombilloCocina
            // 
            btnBombilloCocina.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloCocina.Location = new Point(371, 474);
            btnBombilloCocina.Name = "btnBombilloCocina";
            btnBombilloCocina.Size = new Size(61, 93);
            btnBombilloCocina.TabIndex = 11;
            btnBombilloCocina.Text = "BombilloCocina";
            btnBombilloCocina.UseVisualStyleBackColor = true;
            btnBombilloCocina.Click += btnBombilloCocina_Click;
            // 
            // btnBombilloSala
            // 
            btnBombilloSala.BackColor = Color.White;
            btnBombilloSala.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloSala.Location = new Point(498, 483);
            btnBombilloSala.Name = "btnBombilloSala";
            btnBombilloSala.Size = new Size(57, 84);
            btnBombilloSala.TabIndex = 12;
            btnBombilloSala.Text = "BombilloSala";
            btnBombilloSala.UseVisualStyleBackColor = false;
            btnBombilloSala.Click += btnBombilloSala_Click_1;
            // 
            // VentanaComedor
            // 
            VentanaComedor.AutoSize = true;
            VentanaComedor.BackColor = Color.Cyan;
            VentanaComedor.Location = new Point(162, 22);
            VentanaComedor.Name = "VentanaComedor";
            VentanaComedor.Size = new Size(176, 29);
            VentanaComedor.TabIndex = 13;
            VentanaComedor.Text = "VentanaComedor";
            VentanaComedor.UseVisualStyleBackColor = false;
            VentanaComedor.CheckedChanged += VentanaComedor_CheckedChanged;
            // 
            // VentanaHabitacion
            // 
            VentanaHabitacion.AutoSize = true;
            VentanaHabitacion.BackColor = Color.Cyan;
            VentanaHabitacion.Location = new Point(616, 20);
            VentanaHabitacion.Name = "VentanaHabitacion";
            VentanaHabitacion.Size = new Size(186, 29);
            VentanaHabitacion.TabIndex = 14;
            VentanaHabitacion.Text = "VentanaHabitacion";
            VentanaHabitacion.UseVisualStyleBackColor = false;
            VentanaHabitacion.CheckedChanged += VentanaHabitacion_CheckedChanged;
            // 
            // VentanaCocina
            // 
            VentanaCocina.AutoSize = true;
            VentanaCocina.BackColor = Color.Cyan;
            VentanaCocina.Location = new Point(93, 596);
            VentanaCocina.Name = "VentanaCocina";
            VentanaCocina.Size = new Size(154, 29);
            VentanaCocina.TabIndex = 15;
            VentanaCocina.Text = "VentanaCocina";
            VentanaCocina.UseVisualStyleBackColor = false;
            VentanaCocina.CheckedChanged += VentanaCocina_CheckedChanged;
            // 
            // VentanaSala
            // 
            VentanaSala.AutoSize = true;
            VentanaSala.BackColor = Color.Cyan;
            VentanaSala.Location = new Point(856, 570);
            VentanaSala.Name = "VentanaSala";
            VentanaSala.Size = new Size(133, 29);
            VentanaSala.TabIndex = 16;
            VentanaSala.Text = "VentanaSala";
            VentanaSala.UseVisualStyleBackColor = false;
            VentanaSala.CheckedChanged += VentanaSala_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 122);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 21;
            // 
            // aireAcondicionadoComedor
            // 
            aireAcondicionadoComedor.BackColor = Color.LightSteelBlue;
            aireAcondicionadoComedor.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoComedor.Location = new Point(125, 166);
            aireAcondicionadoComedor.Name = "aireAcondicionadoComedor";
            aireAcondicionadoComedor.Size = new Size(61, 92);
            aireAcondicionadoComedor.TabIndex = 22;
            aireAcondicionadoComedor.Text = "aireAcondicionadoComedor";
            aireAcondicionadoComedor.UseVisualStyleBackColor = false;
            aireAcondicionadoComedor.Click += aireAcondicionadoComedor_Click;
            // 
            // aireAcondicionadoHabitacion
            // 
            aireAcondicionadoHabitacion.BackColor = SystemColors.ActiveCaption;
            aireAcondicionadoHabitacion.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoHabitacion.Location = new Point(625, 148);
            aireAcondicionadoHabitacion.Name = "aireAcondicionadoHabitacion";
            aireAcondicionadoHabitacion.Size = new Size(61, 92);
            aireAcondicionadoHabitacion.TabIndex = 23;
            aireAcondicionadoHabitacion.Text = "aireAcondicionadoHabitacion";
            aireAcondicionadoHabitacion.UseVisualStyleBackColor = false;
            aireAcondicionadoHabitacion.Click += aireAcondicionadoHabitacion_Click;
            // 
            // aireAcondicionadoCocina
            // 
            aireAcondicionadoCocina.BackColor = SystemColors.ActiveCaption;
            aireAcondicionadoCocina.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoCocina.Location = new Point(143, 475);
            aireAcondicionadoCocina.Name = "aireAcondicionadoCocina";
            aireAcondicionadoCocina.Size = new Size(61, 92);
            aireAcondicionadoCocina.TabIndex = 24;
            aireAcondicionadoCocina.Text = "aireAcondicionadoCocina";
            aireAcondicionadoCocina.UseVisualStyleBackColor = false;
            aireAcondicionadoCocina.Click += aireAcondicionadoCocina_Click;
            // 
            // aireAcondicionadoSala
            // 
            aireAcondicionadoSala.BackColor = SystemColors.ActiveCaption;
            aireAcondicionadoSala.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoSala.Location = new Point(741, 483);
            aireAcondicionadoSala.Name = "aireAcondicionadoSala";
            aireAcondicionadoSala.Size = new Size(61, 92);
            aireAcondicionadoSala.TabIndex = 25;
            aireAcondicionadoSala.Text = "aireAcondicionadoSala";
            aireAcondicionadoSala.UseVisualStyleBackColor = false;
            aireAcondicionadoSala.Click += aireAcondicionadoSala_Click_1;
            // 
            // toolTip1
            // 
            toolTip1.OwnerDraw = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-396, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1714, 847);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // OperacionesLogicas
            // 
            OperacionesLogicas.Location = new Point(1037, 573);
            OperacionesLogicas.Name = "OperacionesLogicas";
            OperacionesLogicas.Size = new Size(218, 34);
            OperacionesLogicas.TabIndex = 27;
            OperacionesLogicas.Text = "Operaciones Logicas";
            OperacionesLogicas.UseVisualStyleBackColor = true;
            OperacionesLogicas.Click += OperacionesLogicas_Click;
            // 
            // PuertaPrincipal
            // 
            PuertaPrincipal.AutoSize = true;
            PuertaPrincipal.BackColor = Color.FromArgb(192, 64, 0);
            PuertaPrincipal.Location = new Point(300, 723);
            PuertaPrincipal.Name = "PuertaPrincipal";
            PuertaPrincipal.Size = new Size(154, 29);
            PuertaPrincipal.TabIndex = 28;
            PuertaPrincipal.Text = "PuertaPrincipal";
            PuertaPrincipal.UseVisualStyleBackColor = false;
            PuertaPrincipal.CheckedChanged += PuertaPrincipal_CheckedChanged;
            // 
            // SensorHabitacionPresencia
            // 
            SensorHabitacionPresencia.AutoSize = true;
            SensorHabitacionPresencia.Location = new Point(625, 374);
            SensorHabitacionPresencia.Name = "SensorHabitacionPresencia";
            SensorHabitacionPresencia.Size = new Size(250, 29);
            SensorHabitacionPresencia.TabIndex = 30;
            SensorHabitacionPresencia.Text = "SensorHabitacionPresencia";
            SensorHabitacionPresencia.UseVisualStyleBackColor = true;
            SensorHabitacionPresencia.CheckedChanged += SensorHabitacionPresencia_CheckedChanged;
            // 
            // SensorCocinaaPresencia
            // 
            SensorCocinaaPresencia.AutoSize = true;
            SensorCocinaaPresencia.Location = new Point(89, 374);
            SensorCocinaaPresencia.Name = "SensorCocinaaPresencia";
            SensorCocinaaPresencia.Size = new Size(218, 29);
            SensorCocinaaPresencia.TabIndex = 31;
            SensorCocinaaPresencia.Text = "SensorCocinaPresencia";
            SensorCocinaaPresencia.UseVisualStyleBackColor = true;
            SensorCocinaaPresencia.CheckedChanged += SensorCocinaaPresencia_CheckedChanged;
            // 
            // SensorSalaPresencia
            // 
            SensorSalaPresencia.AutoSize = true;
            SensorSalaPresencia.Location = new Point(449, 622);
            SensorSalaPresencia.Name = "SensorSalaPresencia";
            SensorSalaPresencia.Size = new Size(197, 29);
            SensorSalaPresencia.TabIndex = 32;
            SensorSalaPresencia.Text = "SensorSalaPresencia";
            SensorSalaPresencia.UseVisualStyleBackColor = true;
            SensorSalaPresencia.CheckedChanged += SensorSalaPresencia_CheckedChanged;
            // 
            // SensorComedorPresencia
            // 
            SensorComedorPresencia.AutoSize = true;
            SensorComedorPresencia.Location = new Point(315, 166);
            SensorComedorPresencia.Name = "SensorComedorPresencia";
            SensorComedorPresencia.Size = new Size(240, 29);
            SensorComedorPresencia.TabIndex = 33;
            SensorComedorPresencia.Text = "SensorComedorPresencia";
            SensorComedorPresencia.UseVisualStyleBackColor = true;
            SensorComedorPresencia.CheckedChanged += SensorComedorPresencia_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 128, 0);
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 22);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 37;
            label5.Text = "Temp1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(877, 361);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 38;
            label2.Text = "Temp4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 128, 0);
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 374);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 39;
            label6.Text = "Temp3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 128, 0);
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(856, 21);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 40;
            label7.Text = "Temp2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 783);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(SensorComedorPresencia);
            Controls.Add(SensorSalaPresencia);
            Controls.Add(SensorCocinaaPresencia);
            Controls.Add(SensorHabitacionPresencia);
            Controls.Add(PuertaPrincipal);
            Controls.Add(OperacionesLogicas);
            Controls.Add(aireAcondicionadoSala);
            Controls.Add(aireAcondicionadoCocina);
            Controls.Add(aireAcondicionadoHabitacion);
            Controls.Add(aireAcondicionadoComedor);
            Controls.Add(label1);
            Controls.Add(VentanaSala);
            Controls.Add(VentanaCocina);
            Controls.Add(VentanaHabitacion);
            Controls.Add(VentanaComedor);
            Controls.Add(btnBombilloSala);
            Controls.Add(btnBombilloCocina);
            Controls.Add(btnBombilloHabitacion);
            Controls.Add(btnBombilloComedor);
            Controls.Add(PuertaHabitacion);
            Controls.Add(PuertaSala);
            Controls.Add(PuertaCocina);
            Controls.Add(PuertaComedor);
            Controls.Add(CocinaTemp);
            Controls.Add(SalaTemp);
            Controls.Add(HabitacionTemp);
            Controls.Add(ComedorTemp);
            Controls.Add(Lahora);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ComedorTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)HabitacionTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)CocinaTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Hora;
        private Label Lahora;
        private TrackBar ComedorTemp;
        private TrackBar HabitacionTemp;
        private TrackBar SalaTemp;
        private TrackBar CocinaTemp;
        private CheckBox PuertaComedor;
        private CheckBox PuertaHabitacion;
        private CheckBox PuertaCocina;
        private CheckBox PuertaSala;
        private Button btnBombilloComedor;
        private Button btnBombilloHabitacion;
        private Button btnBombilloCocina;
        private Button btnBombilloSala;
        private CheckBox VentanaComedor;
        private CheckBox VentanaHabitacion;
        private CheckBox VentanaCocina;
        private CheckBox VentanaSala;
        private Label label1;
        private Button aireAcondicionadoComedor;
        private Button aireAcondicionadoHabitacion;
        private Button aireAcondicionadoCocina;
        private Button aireAcondicionadoSala;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button OperacionesLogicas;
        private CheckBox PuertaPrincipal;
        private CheckBox SensorHabitacionPresencia;
        private CheckBox SensorCocinaaPresencia;
        private CheckBox SensorSalaPresencia;
        private CheckBox SensorComedorPresencia;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
    }
}
