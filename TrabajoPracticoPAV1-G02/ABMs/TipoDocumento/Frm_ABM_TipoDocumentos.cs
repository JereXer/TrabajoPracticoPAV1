using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.TipoDocumento;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_TipoDocumentos : Form
    {
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaTipoDocumento formAltaTipoDocumento = new Frm_AltaTipoDocumento();
            formAltaTipoDocumento.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarTipoDocumento formModificarTipoDocumento = new Frm_ModificarTipoDocumento();
            formModificarTipoDocumento.Show();
        }
    }
}
