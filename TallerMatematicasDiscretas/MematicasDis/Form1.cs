using System;
using System.Windows.Forms;

namespace MematicasDis
{
    public partial class Form1 : Form


    {
        private ToolTip toolTip = new ToolTip();  // Declaramos el ToolTip

        private System.Timers.Timer timer;
        private int secondsPassed = 0;
        private int millisecondsPassed = 0;
        private int microsecondsPassed = 0;
        private bool bombilloEncendido = false;
        private Image bombilloApagado;
        private Image bombilloEncendidoImage;
        private bool bombilloComedorEncendido = false;
        private bool bombilloHabitacionEncendido = false;
        private bool bombilloCocinaEncendido = false;
        private bool bombilloSalaEncendido = false;
        private bool aireAcondicionadoComedorEncendido = false;
        private bool aireAcondicionadoHabitacionEncendido = false;
        private bool aireAcondicionadoCocinaEncendido = false;
        private bool aireAcondicionadoSalaEncendido = false;
        // Variables de temperatura (inicialmente su valor podría ser 20, por ejemplo)
        private int temperaturaComedor = 20;
        private int temperaturaHabitacion = 20;
        private int temperaturaCocina = 20;
        private int temperaturaSala = 20;

        // Variables para saber si las puertas y ventanas están cerradas
        private bool ventanaComedorCerrada = true;
        private bool puertaComedorCerrada = true;
        private bool ventanaHabitacionCerrada = true;
        private bool puertaHabitacionCerrada = true;
        private bool ventanaCocinaCerrada = true;
        private bool puertaCocinaCerrada = true;
        private bool ventanaSalaCerrada = true;
        private bool puertaSalaCerrada = true;

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

            // Inicializar los botones con el símbolo de aire acondicionado apagado
            aireAcondicionadoComedor.Text = "❄️ Aire Apagado";  // Puedes usar el símbolo ❄️ o cualquier otro
            aireAcondicionadoHabitacion.Text = "❄️ Aire Apagado";
            aireAcondicionadoCocina.Text = "❄️ Aire Apagado";
            aireAcondicionadoSala.Text = "❄️ Aire Apagado";

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
            // Encender las luces si la hora está entre 6:00 AM y 6:00 PM

            if (customHours >= 18 || customHours < 6)
            {
                if (!bombilloComedorEncendido)
                    EncenderLucesComedor();
                if (!bombilloHabitacionEncendido)
                    EncenderLucesHabitacion();
                if (!bombilloCocinaEncendido)
                    EncenderLucesCocina();
                if (!bombilloSalaEncendido)
                    EncenderLucesSala();
            }
            else
            {
                if (bombilloComedorEncendido)
                    ApagarLucesComedor();
                if (bombilloHabitacionEncendido)
                    ApagarLucesHabitacion();
                if (bombilloCocinaEncendido)
                    ApagarLucesCocina();
                if (bombilloSalaEncendido)
                    ApagarLucesSala();
            }

            // Detener el temporizador después de 24 horas (reiniciar el contador)
            if (customHours >= 24)
            {
                secondsPassed = 0;
                timer.Stop();
                timer.Start();
            }
        }
        private void VerificarAireComedor()
        {
            if (temperaturaComedor > 22 && ventanaComedorCerrada && puertaComedorCerrada)
            {
                EncenderAireAcondicionadoComedor();
            }
            else
            {
                ApagarAireAcondicionadoComedor();
            }
        }

        private void EncenderLucesComedor()
        {
            btnBombilloComedor.Text = "💡 Apagar";
            btnBombilloComedor.ForeColor = Color.Yellow;
            bombilloComedorEncendido = true;
        }
        private void ApagarLucesComedor()
        {
            btnBombilloComedor.Text = "💡 Apagar";
            btnBombilloComedor.ForeColor = Color.Gray;
            bombilloComedorEncendido = false;
        }

        private void EncenderLucesHabitacion()
        {
            btnBombilloHabitacion.Text = "💡 Apagar";
            btnBombilloHabitacion.ForeColor = Color.Yellow;
            bombilloHabitacionEncendido = true;
        }

        private void ApagarLucesHabitacion()
        {
            btnBombilloHabitacion.Text = "💡 Apagar";
            btnBombilloHabitacion.ForeColor = Color.Gray;
            bombilloHabitacionEncendido = false;
        }

        private void EncenderLucesCocina()
        {
            btnBombilloCocina.Text = "💡 Apagar";
            btnBombilloCocina.ForeColor = Color.Yellow;
            bombilloCocinaEncendido = true;
        }

        private void ApagarLucesCocina()
        {
            btnBombilloCocina.Text = "💡 Apagar";
            btnBombilloCocina.ForeColor = Color.Gray;
            bombilloCocinaEncendido = false;
        }

        private void EncenderLucesSala()
        {
            btnBombilloSala.Text = "💡 Apagar";
            btnBombilloSala.ForeColor = Color.Yellow;
            bombilloSalaEncendido = true;
        }

        private void ApagarLucesSala()
        {
            btnBombilloSala.Text = "💡 Apagar";
            btnBombilloSala.ForeColor = Color.Gray;
            bombilloSalaEncendido = false;
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
        {// Obtener el valor del deslizador (TrackBar)
         // Obtener el valor del deslizador (TrackBar)
            temperaturaComedor = ComedorTemp.Value;

            // Actualizar el ToolTip con la temperatura actual
            toolTip.SetToolTip(ComedorTemp, "Temperatura: " + temperaturaComedor + "°C");

            VerificarAireComedor();

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
            ventanaComedorCerrada = VentanaComedor.Checked; // Se actualiza la variable con el valor del CheckBox
                                                            // Llamamos a la función para encender/apagar el aire acondicionado en función de la temperatura y el estado de las puertas y ventanas
            VerificarAireComedor();
        }



        private void PuertaComedor_CheckedChanged(object sender, EventArgs e)
        {
            puertaComedorCerrada = PuertaComedor.Checked; // Se actualiza la variable con el valor del CheckBox
                                                          // Llamamos a la función para encender/apagar el aire acondicionado en función de la temperatura y el estado de las puertas y ventanas
            VerificarAireComedor();

        }

        private void VentanaHabitacion_CheckedChanged(object sender, EventArgs e)
        {
            ventanaHabitacionCerrada = VentanaHabitacion.Checked;  // Suponiendo que VentanaHabitacion es un control tipo CheckBox
            EncenderAireAcondicionadoHabitacion();

        }

        private void PuertaHabitacion_CheckedChanged(object sender, EventArgs e)
        {
            puertaHabitacionCerrada = PuertaHabitacion.Checked;  // Suponiendo que PuertaHabitacion es un control tipo CheckBox
            EncenderAireAcondicionadoHabitacion();

        }

        private void VentanaCocina_CheckedChanged(object sender, EventArgs e)
        {
            ventanaCocinaCerrada = VentanaCocina.Checked;  // Suponiendo que VentanaCocina es un control tipo CheckBox
            EncenderAireAcondicionadoCocina();

        }

        private void PuertaCocina_CheckedChanged(object sender, EventArgs e)
        {
            puertaCocinaCerrada = PuertaCocina.Checked;  // Suponiendo que PuertaCocina es un control tipo CheckBox
            EncenderAireAcondicionadoCocina();

        }

        private void VentanaSala_CheckedChanged(object sender, EventArgs e)
        {
            ventanaSalaCerrada = VentanaSala.Checked;  // Suponiendo que VentanaSala es un control tipo CheckBox
            EncenderAireAcondicionadoSala();


        }

        private void PuertaSala_CheckedChanged(object sender, EventArgs e)
        {
            puertaSalaCerrada = PuertaSala.Checked;  // Suponiendo que PuertaSala es un control tipo CheckBox
            EncenderAireAcondicionadoSala();

        }

        private void btnSensorComedor_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                if (!bombilloComedorEncendido)
                    EncenderLucesComedor();
            }

        }

        private void btnSensorHabitacion_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                if (!bombilloHabitacionEncendido)
                    EncenderLucesHabitacion();
            }

        }

        private void btnSensorCocina_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                if (!bombilloCocinaEncendido)
                    EncenderLucesCocina();
            }

        }

        private void btonSensorsala_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                if (!bombilloSalaEncendido)
                    EncenderLucesSala();
            }

        }

        private void aireAcondicionadoComedor_Click(object sender, EventArgs e)
        {

        }

        private void aireAcondicionadoHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void aireAcondicionadoCocina_Click(object sender, EventArgs e)
        {

        }

        private void aireAcondicionadoSala_Click(object sender, EventArgs e)
        {

        }

        private void HabitacionTemp_Scroll(object sender, EventArgs e)
        {
            temperaturaHabitacion = HabitacionTemp.Value;
            toolTip.SetToolTip(HabitacionTemp, "Temperatura: " + temperaturaHabitacion + "°C");

            if (temperaturaHabitacion > 22 && ventanaHabitacionCerrada && puertaHabitacionCerrada)
            {
                EncenderAireAcondicionadoHabitacion();
            }
            else
            {
                ApagarAireAcondicionadoHabitacion();
            }

        }

        private void CocinaTemp_Scroll(object sender, EventArgs e)
        {
            temperaturaCocina = CocinaTemp.Value;
            toolTip.SetToolTip(CocinaTemp, "Temperatura: " + temperaturaCocina + "°C");

            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaCocinaCerrada)
            {
                EncenderAireAcondicionadoCocina();
            }
            else
            {
                ApagarAireAcondicionadoCocina();
            }


        }

        private void SalaTemp_Scroll(object sender, EventArgs e)
        {
            temperaturaSala = SalaTemp.Value;
            toolTip.SetToolTip(SalaTemp, "Temperatura: " + temperaturaSala + "°C");

            if (temperaturaSala > 22 && ventanaSalaCerrada && puertaSalaCerrada)
            {
                EncenderAireAcondicionadoSala();
            }
            else
            {
                ApagarAireAcondicionadoSala();
            }

        }


        private void EncenderAireAcondicionadoComedor()
        {

            // Comprobar que la temperatura es mayor a 22°C y que tanto la ventana como la puerta estén cerradas
            if (temperaturaComedor > 22 && ventanaComedorCerrada && puertaComedorCerrada)
            {
                aireAcondicionadoComedorEncendido = true;
                aireAcondicionadoComedor.Text = "🌬️ Aire Encendido";  // Símbolo de aire encendido
                aireAcondicionadoComedor.ForeColor = Color.Blue;  // Cambiar color a azul cuando está encendido
            }
            else
            {
                // Si las condiciones no se cumplen, apagamos el aire acondicionado
                ApagarAireAcondicionadoComedor();  // Apagar el aire acondicionado si no se cumplen las condiciones
            }
        }

        private void ApagarAireAcondicionadoComedor()
        {
            aireAcondicionadoComedorEncendido = false;
            aireAcondicionadoComedor.Text = "❄️ Aire Apagado";  // Símbolo de aire apagado
            aireAcondicionadoComedor.ForeColor = Color.Gray;  // Color gris cuando está apagado

        }

        // Repítelo para las demás habitaciones de manera similar...

        private void EncenderAireAcondicionadoHabitacion()
        {
            if (temperaturaHabitacion > 22 && ventanaHabitacionCerrada && puertaHabitacionCerrada)
            {
                aireAcondicionadoHabitacionEncendido = true;
                aireAcondicionadoHabitacion.Text = "🌬️ Aire Encendido";
                aireAcondicionadoHabitacion.ForeColor = Color.Blue;
                
            }
        }

        private void ApagarAireAcondicionadoHabitacion()
        {
            aireAcondicionadoHabitacionEncendido = false;
            aireAcondicionadoHabitacion.Text = "❄️ Aire Apagado";
            aireAcondicionadoHabitacion.ForeColor = Color.Gray;
            
        }

        private void EncenderAireAcondicionadoCocina()
        {
            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaCocinaCerrada)
            {
                aireAcondicionadoCocinaEncendido = true;
                aireAcondicionadoCocina.Text = "🌬️ Aire Encendido";
                aireAcondicionadoCocina.ForeColor = Color.Blue;
                
            }
        }

        private void ApagarAireAcondicionadoCocina()
        {
            aireAcondicionadoCocinaEncendido = false;
            aireAcondicionadoCocina.Text = "❄️ Aire Apagado";
            aireAcondicionadoCocina.ForeColor = Color.Gray;
            
        }

        private void EncenderAireAcondicionadoSala()
        {
            if (temperaturaSala > 22 && ventanaSalaCerrada && puertaSalaCerrada)
            {
                aireAcondicionadoSalaEncendido = true;
                aireAcondicionadoSala.Text = "🌬️ Aire Encendido";
                aireAcondicionadoSala.ForeColor = Color.Blue;
                
            }
        }

        private void ApagarAireAcondicionadoSala()
        {
            aireAcondicionadoSalaEncendido = false;
            aireAcondicionadoSala.Text = "❄️ Aire Apagado";
            aireAcondicionadoSala.ForeColor = Color.Gray;
            
        }
        

        





    }


}




















