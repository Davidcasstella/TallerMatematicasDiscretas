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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ComedorTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HabitacionTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CocinaTemp).BeginInit();
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
            Lahora.BackColor = Color.Chartreuse;
            Lahora.Location = new Point(868, 335);
            Lahora.Name = "Lahora";
            Lahora.Size = new Size(50, 25);
            Lahora.TabIndex = 0;
            Lahora.Text = "Reloj";
            Lahora.Click += Lahora_Click;
            // 
            // ComedorTemp
            // 
            ComedorTemp.Location = new Point(89, 38);
            ComedorTemp.Name = "ComedorTemp";
            ComedorTemp.Orientation = Orientation.Vertical;
            ComedorTemp.Size = new Size(69, 156);
            ComedorTemp.TabIndex = 1;
            // 
            // HabitacionTemp
            // 
            HabitacionTemp.Location = new Point(665, 38);
            HabitacionTemp.Name = "HabitacionTemp";
            HabitacionTemp.Orientation = Orientation.Vertical;
            HabitacionTemp.Size = new Size(69, 156);
            HabitacionTemp.TabIndex = 2;
            // 
            // SalaTemp
            // 
            SalaTemp.Location = new Point(665, 289);
            SalaTemp.Name = "SalaTemp";
            SalaTemp.Orientation = Orientation.Vertical;
            SalaTemp.Size = new Size(69, 156);
            SalaTemp.TabIndex = 3;
            // 
            // CocinaTemp
            // 
            CocinaTemp.Location = new Point(89, 289);
            CocinaTemp.Name = "CocinaTemp";
            CocinaTemp.Orientation = Orientation.Vertical;
            CocinaTemp.Size = new Size(69, 156);
            CocinaTemp.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(179, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(889, 136);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(179, 262);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(797, 262);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 532);
            Controls.Add(checkBox2);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox1);
            Controls.Add(CocinaTemp);
            Controls.Add(SalaTemp);
            Controls.Add(HabitacionTemp);
            Controls.Add(ComedorTemp);
            Controls.Add(Lahora);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ComedorTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)HabitacionTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)CocinaTemp).EndInit();
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
