namespace TaSaindoDajaulaOmonstro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                this.Visible = false;
                MessageBox.Show("logado com sucesso!");
                frmMenu fm = new frmMenu();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorreros.tente novamente!");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastrarUsuario cadastro = new frmCadastrarUsuario();
            cadastro.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
