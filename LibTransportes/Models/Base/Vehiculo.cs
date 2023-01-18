using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibTransportes.Models.Base
{
    public abstract class Vehiculo
    {
        protected Vehiculo(string nombre, string modelo)
        {
            Nombre = nombre;
            Modelo = modelo;
        }

        public string Nombre { get; set; }
        public string Modelo { get; set; }

        public abstract string Acelerar();
        public abstract string Frenar();

        public override string ToString()
        {
            return "Nombre: "+Nombre+" Modelo: "+Modelo;
        }
    }
}
