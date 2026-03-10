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
            btnEntrar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top;
            btnEntrar.BackColor = Color.SpringGreen;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(78, 106);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(90, 34);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(48, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(48, 71);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(144, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Location = new Point(42, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Location = new Point(42, 53);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(814, 450);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSenha);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(287, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 143);
            panel1.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(814, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
