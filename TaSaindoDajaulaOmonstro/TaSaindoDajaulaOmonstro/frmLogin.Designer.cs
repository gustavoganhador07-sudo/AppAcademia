namespace TaSaindoDajaulaOmonstro
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label2 = new Label();
            txtUsuario = new TextBox();
            btnEntrar = new Button();
            label3 = new Label();
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            lblCadastro = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Location = new Point(352, 172);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(352, 190);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 23);
            txtUsuario.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top;
            btnEntrar.BackColor = Color.SpringGreen;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(375, 269);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(90, 34);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Location = new Point(352, 222);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(352, 240);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(144, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new Point(375, 320);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(99, 15);
            lblCadastro.TabIndex = 9;
            lblCadastro.TabStop = true;
            lblCadastro.Text = "Cadastro  usuário";
            lblCadastro.LinkClicked += lblCadastro_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(814, 450);
            Controls.Add(lblCadastro);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            Text = "Form1";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtUsuario;
        private Button btnEntrar;
        private Label label3;
        private TextBox txtSenha;
        private PictureBox pictureBox1;
        private LinkLabel lblCadastro;
    }
}
