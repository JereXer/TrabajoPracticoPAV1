using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.Clases;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_TipoDocumentos : Form
    {
        BD_acceso_a_datos _BD = new BD_acceso_a_datos();

        public Frm_ABM_TipoDocumentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void Frm_ABM_TipoDocumentos_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!chkBoxTodos.Checked && txtBoxNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una opcion.", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (chkBoxTodos.Checked)
            {
                DataTable tabla = new DataTable();
                //Acá tiene que cargar los datos y buscar los tipos documentos
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
