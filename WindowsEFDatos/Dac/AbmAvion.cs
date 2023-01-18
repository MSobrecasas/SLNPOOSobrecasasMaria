using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AbmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }


        public static int Insertar(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }
    }
}
