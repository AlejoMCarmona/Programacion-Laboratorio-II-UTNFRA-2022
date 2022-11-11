using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C18_Forms_01
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.mnsPrincipal.Items[0].Enabled = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmTestDelegados.MdiParent = this;
            this.frmMostrar.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
            this.mnsPrincipal.Items[0].Enabled = true;
        }
    }
}
