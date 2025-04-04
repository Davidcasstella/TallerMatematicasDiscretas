using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicasDiscretastaller
{
    public class Habitacion
    {
        public string Nombre { get; set; }
        public bool SensorPresencia { get; set; }
        public double Temperatura { get; set; }
        public bool SensorApertura { get; set; }
        public bool AireAcondicionado { get; set; }
        public bool Iluminacion { get; set; }

        public Habitacion(string nombre)
        {
            Nombre = nombre;
            SensorPresencia = false;
            Temperatura = 22.0;
            SensorApertura = true;
            AireAcondicionado = false;
            Iluminacion = false;
        }
    }

}
