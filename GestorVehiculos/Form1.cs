using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorVehiculos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbirFormularioTiposVehiculo()
        {
            var frm = new frmTipos();
            frm.ShowDialog();
        }

        private void AbirFormularioVehiculos()
        {
            var frm = new frmVehiculos();
            frm.ShowDialog();
        }

        //Eventos de los botones visuales
        private void btnAbrirVehiculos_Click(object sender, EventArgs e)
        {
            AbirFormularioVehiculos();
        }

        private void btnAbrirTiposVehiculo_Click(object sender, EventArgs e)
        {
            AbirFormularioTiposVehiculo();
        }

        //Eventos del MenuStrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbirFormularioVehiculos();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbirFormularioTiposVehiculo();
        }

        //Eventos del ToolStrip
        private void btnVehiculosToolStrip_Click(object sender, EventArgs e)
        {
            AbirFormularioVehiculos();
        }

        private void btnTiposToolStrip_Click(object sender, EventArgs e)
        {
            AbirFormularioTiposVehiculo();
        }

        private void btnCerrarToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
