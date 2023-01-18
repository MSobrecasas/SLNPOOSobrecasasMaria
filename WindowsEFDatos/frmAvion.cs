using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void limpiar()
        {
            txtID.Text = "";
            txtCapacidad.Text = "";
            txtDenominacion.Text = "";
        }

        private void Mostrar()
        {
            GridAviones.DataSource = AbmAvion.Listar();
            cmbLineaAerea.DataSource = AbmLineaAerea.Listar();
            cmbLineaAerea.DisplayMember = "Nombre";
            cmbLineaAerea.ValueMember = "IdLinea";
        }

        private void Crear()
        {
            try
            {
                Avion avion = new Avion()
                {
                    Capacidad = Convert.ToInt32(txtCapacidad.Text),
                    Denominacion = txtDenominacion.Text,
                    IdLineaAerea = Convert.ToInt32(cmbLineaAerea.SelectedValue.ToString())
                };

                int filasAfectadas = AbmAvion.Insertar(avion);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Insert Correcto");
                    Mostrar();
                    limpiar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Controlar que todos los datos esten completos o sean correctos", "Error");
            }



        }

        private void GridAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = GridAviones.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCapacidad.Text = GridAviones.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDenominacion.Text = GridAviones.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarUno();
        }

        private void MostrarUno()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                Avion avion = AbmAvion.TraerUno(id);
                if (avion == null)
                {
                    MessageBox.Show("No Existe", "Error");
                    return;
                }
                string message = "Capacidad: " + avion.Capacidad + " Denominacion: " + avion.Denominacion;
                MessageBox.Show(message);
            }
            catch (Exception)
            {

                MessageBox.Show("Controlar que todos los datos esten completos o sean correctos", "Error");
            }


        }

        private void Modificar()
        {

            try
            {
                Avion avion = new Avion()
                {
                    Capacidad = Convert.ToInt32(txtCapacidad.Text),
                    Denominacion = txtDenominacion.Text,
                    IdLineaAerea = Convert.ToInt32(cmbLineaAerea.SelectedValue.ToString()),
                    IdAvion = Convert.ToInt32(txtID.Text)
                };

                int filasAfectadas = AbmAvion.Modificar(avion);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Modificar Correcto");
                    Mostrar();
                    limpiar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Controlar que todos los datos esten completos o sean correctos", "Error");
            }

        }


        private void Eliminar()
        {

            try
            {
                Avion avion = new Avion()
                {
                    Capacidad = Convert.ToInt32(txtCapacidad.Text),
                    Denominacion = txtDenominacion.Text,
                    IdLineaAerea = Convert.ToInt32(cmbLineaAerea.SelectedValue.ToString()),
                    IdAvion = Convert.ToInt32(txtID.Text)
                };

                int filasAfectadas = AbmAvion.Eliminar(avion.IdAvion);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminar Correcto");
                    Mostrar();
                    limpiar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Controlar que todos los datos esten completos o sean correctos", "Error");
            }



        }
    }
}
