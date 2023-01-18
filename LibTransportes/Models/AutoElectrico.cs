using LibTransportes.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(string nombre, string modelo, int capacidadBateria, int kilometrosAutonimia) : base(nombre, modelo)
        {
            CapacidadBateria = capacidadBateria;
            KilometrosAutonimia = kilometrosAutonimia;
        }


        public int CapacidadBateria { get; set; }
        public int KilometrosAutonimia { get; set; }

        public override string Acelerar()
        {
            return "El auto Electrico Acelera";
        }

        public override string Frenar()
        {
            return "El auto Electrico Frena";
        }

        public override string ToString()
        {
            return base.ToString() + " Capacidad de Bateria: " + CapacidadBateria + " Kilometros de Autonomia: " + KilometrosAutonimia;
        }
    }
}
