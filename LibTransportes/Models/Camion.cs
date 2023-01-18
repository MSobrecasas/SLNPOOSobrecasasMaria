using LibTransportes.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Camion : Vehiculo
    {
        public Camion(string nombre, string modelo, int capacidadCarga, string conductor, Remolque remolque) : base(nombre, modelo)
        {
            CapacidadCarga = capacidadCarga;
            Conductor = conductor;
            Remolque = remolque;
        }


        public int CapacidadCarga { get; set; }
        public string Conductor { get; set; }
        public Remolque Remolque { get; set; }

        public void QuitarRemolque()
        {
            Remolque = null;
        }

        public override string Acelerar()
        {
            return "El Camion Acelera";
        }

        public override string Frenar()
        {
            return "El Camion Frena";
        }

        public override string ToString()
        {
            return base.ToString() + "\nCapacidad de Carga: "+CapacidadCarga + " Conductor: " + Conductor;
        }
    }
}
