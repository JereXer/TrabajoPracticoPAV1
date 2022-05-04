using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Localidades;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Localidades : Form
    {
        public Frm_ABM_Localidades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void chkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaLocalidades formAltaLocalidades = new Frm_AltaLocalidades();
            formAltaLocalidades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarLocalidad formModificarLocalidades = new Frm_ModificarLocalidad();
            formModificarLocalidades.Show();
        }
    }
}
