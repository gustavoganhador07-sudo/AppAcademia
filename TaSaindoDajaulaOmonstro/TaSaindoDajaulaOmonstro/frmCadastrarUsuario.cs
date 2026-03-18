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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cadastrado com sucesso");
            this.Visible = false;
        }
    }
}
