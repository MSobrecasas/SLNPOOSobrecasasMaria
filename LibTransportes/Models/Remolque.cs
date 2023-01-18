using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Remolque
    {
        public Remolque(int ruedas, int capacidad)
        {
            Ruedas = ruedas;
            Capacidad = capacidad;
        }

        public int Ruedas { get; set; }
        public int Capacidad { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nRuedas: " + Ruedas + " Capacidad: " + Capacidad +"kgs";
        }
    }
}
