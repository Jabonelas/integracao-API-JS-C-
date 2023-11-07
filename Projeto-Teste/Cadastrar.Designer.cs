namespace Projeto_Teste
{
    partial class Cadastrar
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
            lblDados = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDados.Location = new Point(34, 21);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(218, 32);
            lblDados.TabIndex = 22;
            lblDados.Text = "Cadastrar Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(34, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(34, 128);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 17);
            lblTelefone.TabIndex = 19;
            lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(34, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 14;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(34, 146);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(66, 66, 66);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(162, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 40);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(70, 202, 27);
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(34, 263);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 40);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 325);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDados);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDados;
        private Button btnVoltar;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtID;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}