using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AbmLineaAerea
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<LineaAerea> Listar()
        {
            return context.LineaAereas.ToList();
        }
    }
}
