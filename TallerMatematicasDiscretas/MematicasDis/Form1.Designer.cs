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
            btnSensorComedor = new Button();
            btnSensorHabitacion = new Button();
            btnSensorCocina = new Button();
            btonSensorsala = new Button();
            label1 = new Label();
            aireAcondicionadoComedor = new Button();
            aireAcondicionadoHabitacion = new Button();
            aireAcondicionadoCocina = new Button();
            aireAcondicionadoSala = new Button();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            OperacionesLogicas = new Button();
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
            Lahora.BackColor = Color.SpringGreen;
            Lahora.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lahora.Location = new Point(386, 3);
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
            ComedorTemp.Location = new Point(12, 92);
            ComedorTemp.Maximum = 50;
            ComedorTemp.Name = "ComedorTemp";
            ComedorTemp.Orientation = Orientation.Vertical;
            ComedorTemp.Size = new Size(69, 148);
            ComedorTemp.TabIndex = 1;
            ComedorTemp.Scroll += ComedorTemp_Scroll;
            // 
            // HabitacionTemp
            // 
            HabitacionTemp.Location = new Point(876, 73);
            HabitacionTemp.Maximum = 50;
            HabitacionTemp.Name = "HabitacionTemp";
            HabitacionTemp.Orientation = Orientation.Vertical;
            HabitacionTemp.Size = new Size(69, 156);
            HabitacionTemp.TabIndex = 2;
            HabitacionTemp.Scroll += HabitacionTemp_Scroll;
            // 
            // SalaTemp
            // 
            SalaTemp.Location = new Point(846, 434);
            SalaTemp.Maximum = 50;
            SalaTemp.Name = "SalaTemp";
            SalaTemp.Orientation = Orientation.Vertical;
            SalaTemp.Size = new Size(69, 156);
            SalaTemp.TabIndex = 3;
            SalaTemp.Scroll += SalaTemp_Scroll;
            // 
            // CocinaTemp
            // 
            CocinaTemp.Location = new Point(21, 434);
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
            PuertaComedor.Location = new Point(100, 38);
            PuertaComedor.Name = "PuertaComedor";
            PuertaComedor.Size = new Size(163, 29);
            PuertaComedor.TabIndex = 5;
            PuertaComedor.Text = "PuertaComedor";
            PuertaComedor.UseVisualStyleBackColor = true;
            PuertaComedor.CheckedChanged += PuertaComedor_CheckedChanged;
            // 
            // PuertaHabitacion
            // 
            PuertaHabitacion.AutoSize = true;
            PuertaHabitacion.Location = new Point(509, 108);
            PuertaHabitacion.Name = "PuertaHabitacion";
            PuertaHabitacion.Size = new Size(173, 29);
            PuertaHabitacion.TabIndex = 6;
            PuertaHabitacion.Text = "PuertaHabitacion";
            PuertaHabitacion.UseVisualStyleBackColor = true;
            PuertaHabitacion.CheckedChanged += PuertaHabitacion_CheckedChanged;
            // 
            // PuertaCocina
            // 
            PuertaCocina.AutoSize = true;
            PuertaCocina.Location = new Point(293, 452);
            PuertaCocina.Name = "PuertaCocina";
            PuertaCocina.Size = new Size(141, 29);
            PuertaCocina.TabIndex = 7;
            PuertaCocina.Text = "PuertaCocina";
            PuertaCocina.UseVisualStyleBackColor = true;
            PuertaCocina.CheckedChanged += PuertaCocina_CheckedChanged;
            // 
            // PuertaSala
            // 
            PuertaSala.AutoSize = true;
            PuertaSala.Location = new Point(484, 468);
            PuertaSala.Name = "PuertaSala";
            PuertaSala.Size = new Size(120, 29);
            PuertaSala.TabIndex = 8;
            PuertaSala.Text = "PuertaSala";
            PuertaSala.UseVisualStyleBackColor = true;
            PuertaSala.CheckedChanged += PuertaSala_CheckedChanged;
            // 
            // btnBombilloComedor
            // 
            btnBombilloComedor.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloComedor.Location = new Point(100, 184);
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
            btnBombilloHabitacion.Location = new Point(509, 148);
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
            btnBombilloCocina.Location = new Point(143, 497);
            btnBombilloCocina.Name = "btnBombilloCocina";
            btnBombilloCocina.Size = new Size(61, 93);
            btnBombilloCocina.TabIndex = 11;
            btnBombilloCocina.Text = "BombilloCocina";
            btnBombilloCocina.UseVisualStyleBackColor = true;
            btnBombilloCocina.Click += btnBombilloCocina_Click;
            // 
            // btnBombilloSala
            // 
            btnBombilloSala.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBombilloSala.Location = new Point(513, 515);
            btnBombilloSala.Name = "btnBombilloSala";
            btnBombilloSala.Size = new Size(57, 84);
            btnBombilloSala.TabIndex = 12;
            btnBombilloSala.Text = "BombilloSala";
            btnBombilloSala.UseVisualStyleBackColor = true;
            btnBombilloSala.Click += btnBombilloSala_Click_1;
            // 
            // VentanaComedor
            // 
            VentanaComedor.AutoSize = true;
            VentanaComedor.Location = new Point(100, 12);
            VentanaComedor.Name = "VentanaComedor";
            VentanaComedor.Size = new Size(176, 29);
            VentanaComedor.TabIndex = 13;
            VentanaComedor.Text = "VentanaComedor";
            VentanaComedor.UseVisualStyleBackColor = true;
            VentanaComedor.CheckedChanged += VentanaComedor_CheckedChanged;
            // 
            // VentanaHabitacion
            // 
            VentanaHabitacion.AutoSize = true;
            VentanaHabitacion.Location = new Point(509, 73);
            VentanaHabitacion.Name = "VentanaHabitacion";
            VentanaHabitacion.Size = new Size(186, 29);
            VentanaHabitacion.TabIndex = 14;
            VentanaHabitacion.Text = "VentanaHabitacion";
            VentanaHabitacion.UseVisualStyleBackColor = true;
            VentanaHabitacion.CheckedChanged += VentanaHabitacion_CheckedChanged;
            // 
            // VentanaCocina
            // 
            VentanaCocina.AutoSize = true;
            VentanaCocina.Location = new Point(293, 417);
            VentanaCocina.Name = "VentanaCocina";
            VentanaCocina.Size = new Size(154, 29);
            VentanaCocina.TabIndex = 15;
            VentanaCocina.Text = "VentanaCocina";
            VentanaCocina.UseVisualStyleBackColor = true;
            VentanaCocina.CheckedChanged += VentanaCocina_CheckedChanged;
            // 
            // VentanaSala
            // 
            VentanaSala.AutoSize = true;
            VentanaSala.Location = new Point(484, 434);
            VentanaSala.Name = "VentanaSala";
            VentanaSala.Size = new Size(133, 29);
            VentanaSala.TabIndex = 16;
            VentanaSala.Text = "VentanaSala";
            VentanaSala.UseVisualStyleBackColor = true;
            VentanaSala.CheckedChanged += VentanaSala_CheckedChanged;
            // 
            // btnSensorComedor
            // 
            btnSensorComedor.Location = new Point(320, 278);
            btnSensorComedor.Name = "btnSensorComedor";
            btnSensorComedor.Size = new Size(112, 34);
            btnSensorComedor.TabIndex = 17;
            btnSensorComedor.Text = "btnSensorComedor";
            btnSensorComedor.UseVisualStyleBackColor = true;
            btnSensorComedor.Click += btnSensorComedor_Click;
            // 
            // btnSensorHabitacion
            // 
            btnSensorHabitacion.Location = new Point(484, 314);
            btnSensorHabitacion.Name = "btnSensorHabitacion";
            btnSensorHabitacion.Size = new Size(120, 34);
            btnSensorHabitacion.TabIndex = 18;
            btnSensorHabitacion.Text = "btnSensorHabitacion";
            btnSensorHabitacion.UseVisualStyleBackColor = true;
            btnSensorHabitacion.Click += btnSensorHabitacion_Click;
            // 
            // btnSensorCocina
            // 
            btnSensorCocina.Location = new Point(323, 640);
            btnSensorCocina.Name = "btnSensorCocina";
            btnSensorCocina.Size = new Size(124, 34);
            btnSensorCocina.TabIndex = 19;
            btnSensorCocina.Text = "btnSensorCocina";
            btnSensorCocina.UseVisualStyleBackColor = true;
            btnSensorCocina.Click += btnSensorCocina_Click;
            // 
            // btonSensorsala
            // 
            btonSensorsala.Location = new Point(625, 464);
            btonSensorsala.Name = "btonSensorsala";
            btonSensorsala.Size = new Size(164, 34);
            btonSensorsala.TabIndex = 20;
            btonSensorsala.Text = " btnSensorSala";
            btonSensorsala.UseVisualStyleBackColor = true;
            btonSensorsala.Click += btonSensorsala_Click;
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
            aireAcondicionadoComedor.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoComedor.Location = new Point(386, 180);
            aireAcondicionadoComedor.Name = "aireAcondicionadoComedor";
            aireAcondicionadoComedor.Size = new Size(61, 92);
            aireAcondicionadoComedor.TabIndex = 22;
            aireAcondicionadoComedor.Text = "aireAcondicionadoComedor";
            aireAcondicionadoComedor.UseVisualStyleBackColor = true;
            aireAcondicionadoComedor.Click += aireAcondicionadoComedor_Click;
            // 
            // aireAcondicionadoHabitacion
            // 
            aireAcondicionadoHabitacion.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoHabitacion.Location = new Point(625, 148);
            aireAcondicionadoHabitacion.Name = "aireAcondicionadoHabitacion";
            aireAcondicionadoHabitacion.Size = new Size(61, 92);
            aireAcondicionadoHabitacion.TabIndex = 23;
            aireAcondicionadoHabitacion.Text = "aireAcondicionadoHabitacion";
            aireAcondicionadoHabitacion.UseVisualStyleBackColor = true;
            aireAcondicionadoHabitacion.Click += aireAcondicionadoHabitacion_Click;
            // 
            // aireAcondicionadoCocina
            // 
            aireAcondicionadoCocina.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoCocina.Location = new Point(371, 511);
            aireAcondicionadoCocina.Name = "aireAcondicionadoCocina";
            aireAcondicionadoCocina.Size = new Size(61, 92);
            aireAcondicionadoCocina.TabIndex = 24;
            aireAcondicionadoCocina.Text = "aireAcondicionadoCocina";
            aireAcondicionadoCocina.UseVisualStyleBackColor = true;
            aireAcondicionadoCocina.Click += aireAcondicionadoCocina_Click;
            // 
            // aireAcondicionadoSala
            // 
            aireAcondicionadoSala.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aireAcondicionadoSala.Location = new Point(701, 515);
            aireAcondicionadoSala.Name = "aireAcondicionadoSala";
            aireAcondicionadoSala.Size = new Size(61, 92);
            aireAcondicionadoSala.TabIndex = 25;
            aireAcondicionadoSala.Text = "aireAcondicionadoSala";
            aireAcondicionadoSala.UseVisualStyleBackColor = true;
            aireAcondicionadoSala.Click += aireAcondicionadoSala_Click_1;
            // 
            // toolTip1
            // 
            toolTip1.OwnerDraw = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fondo;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 783);
            Controls.Add(OperacionesLogicas);
            Controls.Add(aireAcondicionadoSala);
            Controls.Add(aireAcondicionadoCocina);
            Controls.Add(aireAcondicionadoHabitacion);
            Controls.Add(aireAcondicionadoComedor);
            Controls.Add(label1);
            Controls.Add(btonSensorsala);
            Controls.Add(btnSensorCocina);
            Controls.Add(btnSensorHabitacion);
            Controls.Add(btnSensorComedor);
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
        private Button btnSensorComedor;
        private Button btnSensorHabitacion;
        private Button btnSensorCocina;
        private Button btonSensorsala;
        private Label label1;
        private Button aireAcondicionadoComedor;
        private Button aireAcondicionadoHabitacion;
        private Button aireAcondicionadoCocina;
        private Button aireAcondicionadoSala;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button OperacionesLogicas;
    }
}
