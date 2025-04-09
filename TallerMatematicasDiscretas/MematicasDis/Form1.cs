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
        private bool ventanaComedorCerrada = false;
        private bool puertaComedorCerrada = false;
        private bool ventanaHabitacionCerrada = false;
        private bool puertaHabitacionCerrada = false;
        private bool ventanaCocinaCerrada = false;
        private bool puertaCocinaCerrada = false;
        private bool ventanaSalaCerrada = false;
        private bool puertaSalaCerrada = false;
        private bool puertaPrincipalCerrada = false;
        private bool SensorComedorCerrado = false;
        private bool interruptor = false;


        int totalSecondsInDay = 0;
        int totalMillisecondsInDay = 0;
        int equivalentSeconds = 0;
        int customHours = 0;


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
            totalSecondsInDay = 60 * 60; // Total de segundos en un día real
            totalMillisecondsInDay = (60 * 24) / 1000;

            // Calcular el equivalente en segundos de acuerdo a los segundos transcurridos
            equivalentSeconds = (secondsPassed * totalSecondsInDay) / 24;
            //int equivalentMilliseconds = (secondsPassed * totalMillisecondsInDay);// Cada segundo del temporizador representa 1/24 de un día real

            // Convertir el equivalente de segundos en horas, minutos y segundos
            customHours = equivalentSeconds / 3600; // Convertir segundos a horas
            int customMinutes = (equivalentSeconds % 3600) / 36; // Convertir el residuo de segundos en minutos
            int custommili = (equivalentSeconds % 999) / 11;

            // Mostrar el tiempo en formato HH:MM:SS
            string customTimeString = string.Format("{0:D2}:{1:D2}:{2:D2}", customHours, customMinutes, custommili);

            // Actualizar el label con el formato adecuado
            Lahora.Text = customTimeString;
            // Encender las luces si la hora está entre 6:00 AM y 6:00 PM

            if ((customHours >= 18 || customHours < 6))
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
            if (temperaturaComedor > 22 && ventanaComedorCerrada && puertaComedorCerrada && puertaCocinaCerrada)
            {
                EncenderAireAcondicionadoComedor();
            }
            else
            {
                ApagarAireAcondicionadoComedor();
            }
        }
        private void interruporr()
        {
            if (bombilloComedorEncendido)
            {
                EncenderLucesComedor();

            }
            else
            {
                ApagarLucesComedor();
            }
            bombilloComedorEncendido = !bombilloComedorEncendido;
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void btnBombilloHabitacion_Click(object sender, EventArgs e)
        {


        }

        private void btnBombilloCocina_Click(object sender, EventArgs e)
        {


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
            VerificarAireHabitacion();

        }

        private void VentanaHabitacion_CheckedChanged(object sender, EventArgs e)
        {
            ventanaHabitacionCerrada = VentanaHabitacion.Checked;  // Suponiendo que VentanaHabitacion es un control tipo CheckBox
            EncenderAireAcondicionadoHabitacion();
            VerificarAireHabitacion();


        }

        private void PuertaHabitacion_CheckedChanged(object sender, EventArgs e)
        {
            puertaHabitacionCerrada = PuertaHabitacion.Checked;  // Suponiendo que PuertaHabitacion es un control tipo CheckBox
            EncenderAireAcondicionadoHabitacion();
            VerificarAireHabitacion();
            VerificarAireSala();

        }

        private void VentanaCocina_CheckedChanged(object sender, EventArgs e)
        {
            ventanaCocinaCerrada = VentanaCocina.Checked;  // Suponiendo que VentanaCocina es un control tipo CheckBox
            EncenderAireAcondicionadoCocina();
            VerificarAireCocina();

        }

        private void PuertaCocina_CheckedChanged(object sender, EventArgs e)
        {
            puertaCocinaCerrada = PuertaCocina.Checked;  // Suponiendo que PuertaCocina es un control tipo CheckBox
            EncenderAireAcondicionadoCocina();
            VerificarAireCocina();
            VerificarAireComedor();


        }

        private void VentanaSala_CheckedChanged(object sender, EventArgs e)
        {
            ventanaSalaCerrada = VentanaSala.Checked;  // Suponiendo que VentanaSala es un control tipo CheckBox
            EncenderAireAcondicionadoSala();
            VerificarAireSala();


        }

        private void PuertaSala_CheckedChanged(object sender, EventArgs e)
        {
            puertaSalaCerrada = PuertaSala.Checked;  // Suponiendo que PuertaSala es un control tipo CheckBox
            EncenderAireAcondicionadoSala();
            VerificarAireSala();
            VerificarAireCocina();
        }

        private void btnSensorComedor_Click(object sender, EventArgs e)
        {
            // Verificar si estamos en el rango horario de 6 PM a 6 AM
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                // Si el bombillo no está encendido, encenderlo
                if (!bombilloComedorEncendido)
                {
                    EncenderLucesComedor();  // Llamar a la función que enciende las luces
                }
            }
            else
            {
                // Si no es el rango horario, también puedes encender las luces si lo deseas
                if (!bombilloComedorEncendido)
                {
                    EncenderLucesComedor();
                }
            }

        }

        private void btnSensorHabitacion_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                if (!bombilloHabitacionEncendido)
                    EncenderLucesHabitacion();
            }
            bombilloEncendido = !bombilloEncendido;

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
            // Verificar que la temperatura es mayor o igual a 22°C
            // Y que tanto la puerta como la ventana estén cerradas
            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaSalaCerrada && puertaSalaCerrada && puertaPrincipalCerrada)
            {
                // Si las condiciones se cumplen, encender el aire acondicionado
                aireAcondicionadoComedorEncendido = true;
                aireAcondicionadoComedor.Text = "💨 Aire Encendido";  // Cambiar texto del botón a "Aire Encendido"
                aireAcondicionadoComedor.ForeColor = Color.Blue;  // Cambiar color a azul para indicar que está encendido
            }
            else
            {
                // Si alguna de las condiciones no se cumple, apagar el aire acondicionado
                aireAcondicionadoComedorEncendido = false;
                aireAcondicionadoComedor.Text = "❄️ Aire Apagado";  // Cambiar texto del botón a "Aire Apagado"
                aireAcondicionadoComedor.ForeColor = Color.Gray;  // Cambiar color a gris para indicar que está apagado
            }

        }

        private void aireAcondicionadoHabitacion_Click(object sender, EventArgs e)
        {
            // Verificar que la temperatura es mayor o igual a 22°C
            // Y que tanto la puerta como la ventana estén cerradas en la habitación
            if (temperaturaHabitacion > 22 && ventanaHabitacionCerrada && puertaHabitacionCerrada && puertaComedorCerrada)
            {
                // Si las condiciones se cumplen, encender el aire acondicionado
                aireAcondicionadoHabitacionEncendido = true;
                aireAcondicionadoHabitacion.Text = "💨 Aire Encendido";  // Cambiar texto del botón a "Aire Encendido"
                aireAcondicionadoHabitacion.ForeColor = Color.Blue;  // Cambiar color a azul para indicar que está encendido
            }
            else
            {
                // Si alguna de las condiciones no se cumple, apagar el aire acondicionado
                aireAcondicionadoHabitacionEncendido = false;
                aireAcondicionadoHabitacion.Text = "❄️ Aire Apagado";  // Cambiar texto del botón a "Aire Apagado"
                aireAcondicionadoHabitacion.ForeColor = Color.Gray;  // Cambiar color a gris para indicar que está apagado
            }

        }

        private void aireAcondicionadoCocina_Click(object sender, EventArgs e)
        {
            // Verificar que la temperatura es mayor o igual a 22°C
            // Y que tanto la puerta como la ventana estén cerradas en la cocina
            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaCocinaCerrada && puertaSalaCerrada)
            {
                // Si las condiciones se cumplen, encender el aire acondicionado
                aireAcondicionadoCocinaEncendido = true;
                aireAcondicionadoCocina.Text = "💨 Aire Encendido";  // Cambiar texto del botón a "Aire Encendido"
                aireAcondicionadoCocina.ForeColor = Color.Blue;  // Cambiar color a azul para indicar que está encendido
            }
            else
            {
                // Si alguna de las condiciones no se cumple, apagar el aire acondicionado
                aireAcondicionadoCocinaEncendido = false;
                aireAcondicionadoCocina.Text = "❄️ Aire Apagado";  // Cambiar texto del botón a "Aire Apagado"
                aireAcondicionadoCocina.ForeColor = Color.Gray;  // Cambiar color a gris para indicar que está apagado
            }

        }

        private void aireAcondicionadoSala_Click(object sender, EventArgs e)
        {
            // Verificar que la temperatura es mayor o igual a 22°C
            // Y que tanto la puerta como la ventana estén cerradas en la sala
            if (temperaturaSala > 22 && ventanaSalaCerrada && puertaSalaCerrada && puertaHabitacionCerrada)
            {
                // Si las condiciones se cumplen, encender el aire acondicionado
                aireAcondicionadoSalaEncendido = true;
                aireAcondicionadoSala.Text = "💨 Aire Encendido";  // Cambiar texto del botón a "Aire Encendido"
                aireAcondicionadoSala.ForeColor = Color.Blue;  // Cambiar color a azul para indicar que está encendido
            }
            else
            {
                // Si alguna de las condiciones no se cumple, apagar el aire acondicionado
                aireAcondicionadoSalaEncendido = false;
                aireAcondicionadoSala.Text = "❄ Aire Apagado";  // Cambiar texto del botón a "Aire Apagado"
                aireAcondicionadoSala.ForeColor = Color.Gray;  // Cambiar color a gris para indicar que está apagado
            }

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
            VerificarAireHabitacion();

        }
        private void VerificarAireHabitacion()
        {
            if (temperaturaHabitacion > 22 && ventanaHabitacionCerrada && puertaHabitacionCerrada && puertaComedorCerrada)
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

            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaCocinaCerrada && puertaSalaCerrada)
            {
                EncenderAireAcondicionadoCocina();
            }
            else
            {
                ApagarAireAcondicionadoCocina();
            }
            VerificarAireCocina();


        }
        private void VerificarAireCocina()
        {
            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaCocinaCerrada && puertaSalaCerrada && puertaPrincipalCerrada)
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
            VerificarAireSala();

        }
        private void VerificarAireSala()
        {
            if (temperaturaSala > 22 && ventanaSalaCerrada && puertaSalaCerrada && puertaHabitacionCerrada)
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
            if (temperaturaComedor > 22 && ventanaComedorCerrada && puertaComedorCerrada && puertaCocinaCerrada)
            {

                aireAcondicionadoComedorEncendido = true;
                aireAcondicionadoComedor.Text = "💨 Aire Encendido";  // Símbolo de aire encendido
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
            if (temperaturaHabitacion > 22 && ventanaHabitacionCerrada && puertaHabitacionCerrada && puertaComedorCerrada)
            {
                aireAcondicionadoHabitacionEncendido = true;
                aireAcondicionadoHabitacion.Text = "💨 Aire Encendido";
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
            if (temperaturaCocina > 22 && ventanaCocinaCerrada && puertaSalaCerrada && puertaSalaCerrada && puertaPrincipalCerrada)
            {
                aireAcondicionadoCocinaEncendido = true;
                aireAcondicionadoCocina.Text = "💨 Aire Encendido";
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
            if (temperaturaSala > 22 && ventanaSalaCerrada && puertaSalaCerrada && puertaHabitacionCerrada)
            {
                aireAcondicionadoSalaEncendido = true;
                aireAcondicionadoSala.Text = "💨 Aire Encendido";
                aireAcondicionadoSala.ForeColor = Color.Blue;

            }
        }

        private void ApagarAireAcondicionadoSala()
        {
            aireAcondicionadoSalaEncendido = false;
            aireAcondicionadoSala.Text = "❄️ Aire Apagado";
            aireAcondicionadoSala.ForeColor = Color.Gray;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void aireAcondicionadoSala_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void OperacionesLogicas_Click(object sender, EventArgs e)
        {



            // Configuración del formulario
            Form tablaVerdadForm = new Form();
            tablaVerdadForm.Text = "Tabla de Verdad del Sistema Domótico";
            tablaVerdadForm.Size = new Size(1100, 850);
            tablaVerdadForm.StartPosition = FormStartPosition.CenterParent;
            tablaVerdadForm.BackColor = Color.WhiteSmoke;
            tablaVerdadForm.Font = new Font("Segoe UI", 9);

            // Panel principal
            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Padding = new Padding(10);
            tablaVerdadForm.Controls.Add(mainPanel);

            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;

            // Configuración de encabezados
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Agregar columnas para las entradas (sensores)
            dataGridView.Columns.Add("HoraNocturna", "Hora Nocturna\n(18:00-6:00)");
            dataGridView.Columns.Add("Presencia", "Sensor\nPresencia");
            dataGridView.Columns.Add("TempAlta", "Temperatura\n>22°C");
            dataGridView.Columns.Add("VentanaCerrada", "Ventana\nCerrada");
            dataGridView.Columns.Add("PuertaCerrada", "Puerta\nCerrada");

            // Agregar columnas para las salidas (actuadores)
            dataGridView.Columns.Add("LuzEncendida", "Luz\nEncendida");
            dataGridView.Columns.Add("AireEncendido", "Aire\nAcondicionado");

            // Configurar estilo de columnas
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Diferenciar entradas de salidas
                if (column.Index < 5) // Columnas de entrada
                {
                    column.DefaultCellStyle.BackColor = Color.Lavender;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                }
                else // Columnas de salida
                {
                    column.DefaultCellStyle.BackColor = Color.Honeydew;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

            // Generar todas las combinaciones posibles (2^5 = 32 combinaciones)
            bool[] valores = { false, true };

            foreach (bool horaNocturna in valores)
            {
                foreach (bool presencia in valores)
                {
                    foreach (bool tempAlta in valores)
                    {
                        foreach (bool ventanaCerrada in valores)
                        {
                            foreach (bool puertaCerrada in valores)
                            {
                                // Calcular salidas según las reglas del sistema
                                bool luzEncendida = horaNocturna && presencia;
                                bool aireEncendido = tempAlta && ventanaCerrada && puertaCerrada;

                                // Agregar fila con los valores
                                int rowIndex = dataGridView.Rows.Add();
                                DataGridViewRow row = dataGridView.Rows[rowIndex];

                                // Llenar valores (1/0 para entradas, ON/OFF para salidas)
                                row.Cells["HoraNocturna"].Value = horaNocturna ? "1" : "0";
                                row.Cells["Presencia"].Value = presencia ? "1" : "0";
                                row.Cells["TempAlta"].Value = tempAlta ? "1" : "0";
                                row.Cells["VentanaCerrada"].Value = ventanaCerrada ? "1" : "0";
                                row.Cells["PuertaCerrada"].Value = puertaCerrada ? "1" : "0";
                                row.Cells["LuzEncendida"].Value = luzEncendida ? "ON" : "OFF";
                                row.Cells["AireEncendido"].Value = aireEncendido ? "ON" : "OFF";

                                // Colores para estados ON/OFF
                                row.Cells["LuzEncendida"].Style.ForeColor = luzEncendida ? Color.Green : Color.Red;
                                row.Cells["AireEncendido"].Style.ForeColor = aireEncendido ? Color.Green : Color.Red;
                            }
                        }
                    }
                }
            }

            // Panel para el DataGridView con borde
            Panel gridPanel = new Panel();
            gridPanel.Dock = DockStyle.Fill;
            gridPanel.Padding = new Padding(5);
            gridPanel.BackColor = Color.DarkSlateBlue;
            gridPanel.Controls.Add(dataGridView);
            mainPanel.Controls.Add(gridPanel);

            // Panel para las ecuaciones lógicas con diseño mejorado
            Panel ecuacionPanel = new Panel();
            ecuacionPanel.Dock = DockStyle.Bottom;
            ecuacionPanel.Height = 100;
            ecuacionPanel.BackColor = Color.White;
            ecuacionPanel.Padding = new Padding(15);
            ecuacionPanel.BorderStyle = BorderStyle.FixedSingle;

            RichTextBox rtbEcuaciones = new RichTextBox();
            rtbEcuaciones.Dock = DockStyle.Fill;
            rtbEcuaciones.ReadOnly = true;
            rtbEcuaciones.BackColor = Color.WhiteSmoke;
            rtbEcuaciones.BorderStyle = BorderStyle.None;
            rtbEcuaciones.Font = new Font("Consolas", 10, FontStyle.Regular);

            rtbEcuaciones.Text = @"ECUACIONES LÓGICAS DEL SISTEMA:

                1. CONTROL DE ILUMINACIÓN:
                     Luz Encendida = HoraNocturna ∧ Presencia
                2. CONTROL DE TEMPERATURA:
                 Aire Acondicionado Encendido = TempAlta ∧ VentanaCerrada ∧ PuertaCerrada

                REGLAS:
                • HoraNocturna = 1 cuando la hora está entre 18:00 y 6:00
                • TempAlta = 1 cuando temperatura > 22°C
                • Todos los sensores = 1 cuando están activos/cerrados";

            // Aplicar formato al texto
            rtbEcuaciones.Select(0, 19);
            rtbEcuaciones.SelectionFont = new Font("Consolas", 11, FontStyle.Bold);
            rtbEcuaciones.SelectionColor = Color.DarkSlateBlue;

            rtbEcuaciones.Select(rtbEcuaciones.Text.IndexOf("1. CONTROL"), 17);
            rtbEcuaciones.SelectionFont = new Font("Consolas", 10, FontStyle.Bold);

            rtbEcuaciones.Select(rtbEcuaciones.Text.IndexOf("2. CONTROL"), 17);
            rtbEcuaciones.SelectionFont = new Font("Consolas", 10, FontStyle.Bold);

            rtbEcuaciones.Select(rtbEcuaciones.Text.IndexOf("REGLAS:"), 7);
            rtbEcuaciones.SelectionFont = new Font("Consolas", 10, FontStyle.Bold);
            rtbEcuaciones.SelectionColor = Color.DarkSlateBlue;

            ecuacionPanel.Controls.Add(rtbEcuaciones);
            mainPanel.Controls.Add(ecuacionPanel);

            // Mostrar el formulario
            tablaVerdadForm.ShowDialog();




        }

        private void PuertaPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            puertaPrincipalCerrada = PuertaPrincipal.Checked;  // Suponiendo que PuertaCocina es un control tipo CheckBox
            EncenderAireAcondicionadoCocina();
            VerificarAireCocina();
            VerificarAireComedor();
            VerificarAireCocina();

        }

        private void SensorCocinaPresencia_CheckedChanged(object sender, EventArgs e)
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
            bombilloEncendido = !bombilloEncendido;

        }

        private void SensorHabitacionPresencia_CheckedChanged(object sender, EventArgs e)
        {
            if (customHours >= 18 || customHours < 6)
            {
                // Solo encender las luces si el sensor detecta movimiento y las luces no están encendidas
                if (SensorHabitacionPresencia.Checked && !bombilloHabitacionEncendido)
                {
                    EncenderLucesHabitacion();
                }
                // Si no hay movimiento, apagar las luces
                else if (!SensorHabitacionPresencia.Checked && bombilloHabitacionEncendido)
                {
                    ApagarLucesHabitacion();
                }
            }
            else
            {
                // Fuera del rango de 6:00 AM a 6:00 PM, siempre apagar las luces
                // Si el sensor detecta movimiento fuera de este rango, no encender la luz
                if (bombilloHabitacionEncendido)
                {
                    ApagarLucesHabitacion();
                }
            }


        }

        private void SensorCocinaaPresencia_CheckedChanged(object sender, EventArgs e)
        {
            if (customHours >= 18 || customHours < 6)
            {
                // Solo encender las luces si el sensor detecta movimiento y las luces no están encendidas
                if (SensorCocinaaPresencia.Checked && !bombilloCocinaEncendido)
                {
                    EncenderLucesCocina();
                }
                // Si no hay movimiento, apagar las luces
                else if (!SensorCocinaaPresencia.Checked && bombilloCocinaEncendido)
                {
                    ApagarLucesCocina();
                }
            }
            else
            {
                // Fuera del rango de 6:00 AM a 6:00 PM, siempre apagar las luces
                // Si el sensor detecta movimiento fuera de este rango, no encender la luz
                if (bombilloCocinaEncendido)
                {
                    ApagarLucesCocina();
                }
            }


        }

        private void SensorSalaPresencia_CheckedChanged(object sender, EventArgs e)
        {
            if (customHours >= 18 || customHours < 6)
            {
                // Solo encender las luces si el sensor detecta movimiento y las luces no están encendidas
                if (SensorSalaPresencia.Checked && !bombilloSalaEncendido)
                {
                    EncenderLucesSala();
                }
                // Si no hay movimiento, apagar las luces
                else if (!SensorSalaPresencia.Checked && bombilloSalaEncendido)
                {
                    ApagarLucesSala();
                }
            }
            else
            {
                // Fuera del rango de 6:00 AM a 6:00 PM, siempre apagar las luces
                // Si el sensor detecta movimiento fuera de este rango, no encender la luz
                if (bombilloSalaEncendido)
                {
                    ApagarLucesSala();
                }
            }

        }

        private void SensorComedorPresencia_CheckedChanged(object sender, EventArgs e)
        {


            if (customHours >= 18 || customHours < 6)
            {
                // Solo encender las luces si el sensor detecta movimiento y las luces no están encendidas
                if (SensorComedorPresencia.Checked && !bombilloComedorEncendido)
                {
                    EncenderLucesComedor();
                }
                // Si no hay movimiento, apagar las luces
                else if (!SensorComedorPresencia.Checked && bombilloComedorEncendido)
                {
                    ApagarLucesComedor();
                }
            }
            else
            {
                // Fuera del rango de 6:00 AM a 6:00 PM, siempre apagar las luces
                // Si el sensor detecta movimiento fuera de este rango, no encender la luz
                if (bombilloComedorEncendido)
                {
                    ApagarLucesComedor();
                }
            }




        }

        private void SensorPuertaPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            if (customHours >= 18 || customHours < 6)
            {
                // Solo encender las luces si el sensor detecta movimiento y las luces no están encendidas
                if (SensorCocinaaPresencia.Checked && !bombilloCocinaEncendido)
                {
                    EncenderLucesCocina();
                }
                // Si no hay movimiento, apagar las luces
                else if (!SensorCocinaaPresencia.Checked && bombilloCocinaEncendido)
                {
                    ApagarLucesCocina();
                }
            }
            else
            {
                // Fuera del rango de 6:00 AM a 6:00 PM, siempre apagar las luces
                // Si el sensor detecta movimiento fuera de este rango, no encender la luz
                if (bombilloCocinaEncendido)
                {
                    ApagarLucesCocina();
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }


}




















