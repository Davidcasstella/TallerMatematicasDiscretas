using System;
using System.Windows.Forms;

namespace MematicasDis
{
    public partial class Form1 : Form


    {
        private System.Timers.Timer timer;
        private int secondsPassed = 0;
        private int millisecondsPassed = 0;
        private int microsecondsPassed = 0;
        private bool bombilloEncendido = false;
        private Image bombilloApagado;
        private Image bombilloEncendidoImage;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1 segundo
            Hora.Tick += Hora_Tick;
            secondsPassed = 0;
            btnBombilloComedor.Text = "💡 Apagar";
            btnBombilloHabitacion.Text = "💡 Apagar";
            btnBombilloCocina.Text = "💡 Apagar";
            btnBombilloSala.Text = "💡 Apagar";


        }


        private void Lahora_Click(object sender, EventArgs e)
        {
            timer.Start();

        }



        private void Hora_Tick(object sender, EventArgs e)
        {
            secondsPassed++;
            // Un día real tiene 86400 segundos. Dividimos el día en 24 segundos.
            int totalSecondsInDay = 60 * 60; // Total de segundos en un día real
            int totalMillisecondsInDay = (60 * 24) / 1000;

            // Calcular el equivalente en segundos de acuerdo a los segundos transcurridos
            int equivalentSeconds = (secondsPassed * totalSecondsInDay) / 24;
            //int equivalentMilliseconds = (secondsPassed * totalMillisecondsInDay);// Cada segundo del temporizador representa 1/24 de un día real

            // Convertir el equivalente de segundos en horas, minutos y segundos
            int customHours = equivalentSeconds / 3600; // Convertir segundos a horas
            int customMinutes = (equivalentSeconds % 3600) / 60; // Convertir el residuo de segundos en minutos
            int custommili = (equivalentSeconds % 999) / 11;

            // Mostrar el tiempo en formato HH:MM:SS
            string customTimeString = string.Format("{0:D2}:{1:D2}:{2:D2}", customHours, customMinutes, custommili);

            // Actualizar el label con el formato adecuado
            Lahora.Text = customTimeString;

            // Detener el temporizador cuando llegamos a 24 segundos (un "día")
            if (secondsPassed <= 24)
            {
                timer.Stop();  // Detener el temporizador después de 24 segundos
            }
        }


        private void btnBombillo_Click(object sender, EventArgs e)
        {
            {
                if (bombilloEncendido)
                {
                    // Apagar el bombillo (simbolizado por el icono apagado)
                    btnBombilloComedor.Text = "💡";
                    btnBombilloComedor.ForeColor = Color.Gray;
                }
                else
                {
                    // Encender el bombillo (color amarillo)
                    btnBombilloComedor.Text = "💡   ";
                    btnBombilloComedor.ForeColor = Color.Yellow;
                }

                bombilloEncendido = !bombilloEncendido; // Cambiar el estado
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBombilloHabitacion_Click(object sender, EventArgs e)
        {
            {
                if (bombilloEncendido)
                {
                    // Apagar el bombillo (simbolizado por el icono apagado)
                    btnBombilloHabitacion.Text = "💡";
                    btnBombilloHabitacion.ForeColor = Color.Gray;
                }
                else
                {
                    // Encender el bombillo (color amarillo)
                    btnBombilloHabitacion.Text = "💡   ";
                    btnBombilloHabitacion.ForeColor = Color.Yellow;
                }

                bombilloEncendido = !bombilloEncendido; // Cambiar el estado
            }

        }

        private void btnBombilloCocina_Click(object sender, EventArgs e)
        {
            {
                if (bombilloEncendido)
                {
                    // Apagar el bombillo (simbolizado por el icono apagado)
                    btnBombilloCocina.Text = "💡";
                    btnBombilloCocina.ForeColor = Color.Gray;
                }
                else
                {
                    // Encender el bombillo (color amarillo)

                    btnBombilloCocina.Text = "💡   ";
                    btnBombilloCocina.ForeColor = Color.Yellow;
                }

                bombilloEncendido = !bombilloEncendido; // Cambiar el estado
            }

        }



        private void ComedorTemp_Scroll(object sender, EventArgs e)
        {

        }

        private void btnBombilloSala_Click_1(object sender, EventArgs e)
        {
            {
                if (bombilloEncendido)
                {
                    // Apagar el bombillo (simbolizado por el icono apagado)
                    btnBombilloSala.Text = "💡";
                    btnBombilloSala.ForeColor = Color.Gray;
                }
                else
                {
                    // Encender el bombillo (color amarillo)

                    btnBombilloSala.Text = "💡";
                    btnBombilloSala.ForeColor = Color.Yellow;
                }

                bombilloEncendido = !bombilloEncendido; // Cambiar el estado
            }
        }

        private void VentanaComedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PuertaComedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VentanaHabitacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PuertaHabitacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VentanaCocina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PuertaCocina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VentanaSala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PuertaSala_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}




















