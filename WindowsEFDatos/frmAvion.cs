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
            Avion avion= new Avion()
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

        private void GridAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = GridAviones.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCapacidad.Text = GridAviones.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDenominacion.Text = GridAviones.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
