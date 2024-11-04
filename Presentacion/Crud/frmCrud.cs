using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProyClientesEssential.Datos;
using ProyClientesEssential.Logica;

namespace ProyClientesEssential.Presentacion.Crud
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            DClientes funcion = new DClientes();
            DataTable dt = new DataTable();
            funcion.MostrarClientes(ref dt);

            datalistado.DataSource = dt;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Insertarclientes();
        }

        private void Insertarclientes()
        {
            DClientes funcion = new DClientes();
            Lclientes parametros = new Lclientes();

            parametros.Codigo = Convert.ToInt32(txtcodigo.Text);
            parametros.Nombre = txtnombre.Text;
            parametros.Edad = Convert.ToInt32(txtedad.Text);

            funcion.InsertarClientes(parametros);

            MostrarClientes();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = datalistado.SelectedCells[1].Value.ToString();
            txtnombre.Text = datalistado.SelectedCells[2].Value.ToString();
            txtedad.Text = datalistado.SelectedCells[3].Value.ToString();
        }
    }
}
