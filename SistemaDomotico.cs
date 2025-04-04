using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicasDiscretastaller
{
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
            foreach (var habitacion in Habitaciones)
            {
                if (HoraActual.Hour >= 18 || HoraActual.Hour < 6) // Horario nocturno
                {
                    if (habitacion.SensorPresencia)
                        habitacion.Iluminacion = true;
                    else
                        habitacion.Iluminacion = false;
                }

                // Control de temperatura
                if (habitacion.Temperatura > 22.0 && !habitacion.SensorApertura)
                    habitacion.AireAcondicionado = true;
                else
                    habitacion.AireAcondicionado = false;
            }
        }

        public void ActualizarHora()
        {
            HoraActual = HoraActual.AddSeconds(1); // Avanza el reloj un segundo
        }
    }
}
