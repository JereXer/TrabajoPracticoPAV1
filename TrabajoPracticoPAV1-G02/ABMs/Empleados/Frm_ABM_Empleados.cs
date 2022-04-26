using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Empleados;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Empleados : Form
    {
        public Frm_ABM_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaEmpleados formAltaEmpleados = new Frm_AltaEmpleados();
            formAltaEmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarEmpleado formModificarEmpleados = new Frm_ModificarEmpleado();
            formModificarEmpleados.Show();
        }
    }
}
