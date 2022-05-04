using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Barrios;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Barrios : Form
    {
        public Frm_ABM_Barrios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaBarrios formAltaBarrios = new Frm_AltaBarrios();
            formAltaBarrios.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarBarrio formModificarBarrios = new Frm_ModificarBarrio();
            formModificarBarrios.Show();
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
