using System;
using System.Windows.Forms;

namespace MematicasDis
{
    public partial class Form1 : Form


    {
        private System.Timers.Timer timer;
        private int secondsPassed;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1 segundo
            Hora.Tick += Hora_Tick;
            secondsPassed = 0;

        }


        private void Lahora_Click(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            secondsPassed++;

            // Un día real = 24 horas = 24 segundos en este caso
            // Calcular la hora del día en base a los segundos transcurridos
            int totalMillisecondsInDay = 60 * 60 * 1000; // 24 horas * 60 minutos * 60 segundos * 1000 milisegundos
            int equivalentMilliseconds = (secondsPassed * totalMillisecondsInDay) / 24;

            // Convertir el milisegundo equivalente a horas, minutos, segundos y milisegundos
            TimeSpan timeOfDay = TimeSpan.FromMilliseconds(equivalentMilliseconds);

            // Actualizar un label con la hora representada, incluyendo milisegundos
            Lahora.Text = timeOfDay.ToString(@"hh\:mm\:ss");

            // Si se alcanzan los 24 segundos, detener el temporizador
            if (secondsPassed >= 24)
            {
                timer.Stop();
            }
        }



    }
}
