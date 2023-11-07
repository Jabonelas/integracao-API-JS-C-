namespace Projeto_Teste
{
    partial class Buscar
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
            btnBuscarUsuario = new Button();
            lblInformeUsuario = new Label();
            txtIdUsuario = new TextBox();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            btnVoltar = new Button();
            lblDados = new Label();
            SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(8, 156, 206);
            btnBuscarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuario.ForeColor = Color.White;
            btnBuscarUsuario.Location = new Point(295, 64);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(87, 41);
            btnBuscarUsuario.TabIndex = 0;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // lblInformeUsuario
            // 
            lblInformeUsuario.AutoSize = true;
            lblInformeUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformeUsuario.Location = new Point(36, 56);
            lblInformeUsuario.Name = "lblInformeUsuario";
            lblInformeUsuario.Size = new Size(155, 17);
            lblInformeUsuario.TabIndex = 2;
            lblInformeUsuario.Text = "Informe o id do usuário";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(35, 76);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(238, 23);
            txtIdUsuario.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(36, 81);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 23);
            txtID.TabIndex = 3;
            txtID.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(36, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Visible = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new Point(36, 185);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 5;
            txtTelefone.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(36, 131);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 6;
            txtNome.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(36, 65);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 17);
            lblId.TabIndex = 7;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(36, 113);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            lblNome.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(36, 167);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 17);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone";
            lblTelefone.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(36, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            lblEmail.Visible = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(42, 23, 211);
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(97, 272);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(87, 41);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Visible = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDados.Location = new Point(36, 14);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(185, 32);
            lblDados.TabIndex = 12;
            lblDados.Text = "Buscar Usuário";
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 118);
            Controls.Add(lblDados);
            Controls.Add(btnVoltar);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(lblInformeUsuario);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnBuscarUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Buscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarUsuario;
        private Label lblInformeUsuario;
        private TextBox txtIdUsuario;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Label lblId;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Button btnVoltar;
        private Label lblDados;
    }
}