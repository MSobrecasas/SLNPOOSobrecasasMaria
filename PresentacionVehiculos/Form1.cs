using LibTransportes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Camion camion = cargar();
            string message = mensaje(camion);
            MessageBox.Show(message);
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
        }

        private static string mensaje(Camion camion)
        {
            return camion.ToString() + camion.Remolque.ToString();
        }

        private static Camion cargar()
        {
            return new Camion("Atego 1100", "Mercedez Benz", 1000, "Juan perez", new Remolque(12, 100));
        }


        private static void Quitar()
        {
            Camion camion = cargar();
            string message = mensaje(camion);
            MessageBox.Show(message);
            camion.QuitarRemolque();
            if (camion.Remolque != null)
            {
                message = mensaje(camion);
            }
            else
            {
                message = camion.ToString() + " Sin remolque";
            }

            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
