using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaSaindoDajaulaOmonstro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSuplementos_Click(object sender, EventArgs e)
        {
            frmSuplementos frmSP = new frmSuplementos();
            frmSP.ShowDialog();
        }

        private void btnFicha_De_Treino_Click(object sender, EventArgs e)
        {
            frmpagina_do_carlos frmpc = new frmpagina_do_carlos();
            frmpc.ShowDialog();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
