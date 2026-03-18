namespace TaSaindoDajaulaOmonstro
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSuplementos = new Button();
            btnFicha_De_Treino = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 22);
            label1.Name = "label1";
            label1.Size = new Size(149, 22);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // btnSuplementos
            // 
            btnSuplementos.FlatAppearance.BorderSize = 2;
            btnSuplementos.FlatStyle = FlatStyle.Flat;
            btnSuplementos.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuplementos.Image = Properties.Resources.creatina_menor;
            btnSuplementos.ImageAlign = ContentAlignment.MiddleRight;
            btnSuplementos.Location = new Point(27, 97);
            btnSuplementos.Name = "btnSuplementos";
            btnSuplementos.Size = new Size(195, 71);
            btnSuplementos.TabIndex = 2;
            btnSuplementos.Text = "Suplementos";
            btnSuplementos.TextAlign = ContentAlignment.MiddleLeft;
            btnSuplementos.UseVisualStyleBackColor = true;
            btnSuplementos.Click += btnSuplementos_Click;
            // 
            // btnFicha_De_Treino
            // 
            btnFicha_De_Treino.FlatAppearance.BorderSize = 2;
            btnFicha_De_Treino.FlatStyle = FlatStyle.Flat;
            btnFicha_De_Treino.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFicha_De_Treino.Image = Properties.Resources.treino_2__1_;
            btnFicha_De_Treino.ImageAlign = ContentAlignment.MiddleRight;
            btnFicha_De_Treino.Location = new Point(27, 188);
            btnFicha_De_Treino.Name = "btnFicha_De_Treino";
            btnFicha_De_Treino.Size = new Size(246, 54);
            btnFicha_De_Treino.TabIndex = 3;
            btnFicha_De_Treino.Text = "Ficha De Treino";
            btnFicha_De_Treino.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFicha_De_Treino.UseVisualStyleBackColor = true;
            btnFicha_De_Treino.Click += btnFicha_De_Treino_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFicha_De_Treino);
            Controls.Add(btnSuplementos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += frmMenu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSuplementos;
        private Button btnFicha_De_Treino;
    }
}