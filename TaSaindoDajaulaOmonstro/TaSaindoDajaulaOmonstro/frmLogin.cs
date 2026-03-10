namespace TaSaindoDajaulaOmonstro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Carlos";
            string senha = "123";

            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                MessageBox.Show("logado com sucesso!");
                frmMenu fm = new frmMenu();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorreros.tente novamente!");
            }
        }
    }
}
