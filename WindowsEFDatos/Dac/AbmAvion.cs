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

        public static int Modificar(Avion avion)
        {
            Avion origen = context.Aviones.Find(avion.IdAvion);
            origen.Capacidad = avion.Capacidad;
            origen.Denominacion =avion.Denominacion;
            origen.IdLineaAerea = avion.IdLineaAerea;


            return context.SaveChanges();
        }

        public static int Eliminar(int id)
        {
            Avion origen = context.Aviones.Find(id);
            if (origen != null)
            {
                context.Aviones.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Avion TraerUno(int id)
        {
            return context.Aviones.Find(id);
        }
    }
}
