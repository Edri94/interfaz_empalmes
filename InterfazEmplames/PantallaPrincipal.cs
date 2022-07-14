using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEmplames
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrir Reporte Empalme Saldos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void houstonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpalmeSaldos form1 = new EmpalmeSaldos();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
