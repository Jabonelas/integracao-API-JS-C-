namespace Projeto_Teste
{
    partial class Excluir
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
            lblInformeUsuario = new Label();
            txtIdUsuario = new TextBox();
            btnBuscarUsuario = new Button();
            btnExcluir = new Button();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNome = new Label();
            lblId = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtID = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDados.Location = new Point(36, 14);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(185, 32);
            lblDados.TabIndex = 16;
            lblDados.Text = "Buscar Usuário";
            // 
            // lblInformeUsuario
            // 
            lblInformeUsuario.AutoSize = true;
            lblInformeUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformeUsuario.Location = new Point(36, 56);
            lblInformeUsuario.Name = "lblInformeUsuario";
            lblInformeUsuario.Size = new Size(155, 17);
            lblInformeUsuario.TabIndex = 15;
            lblInformeUsuario.Text = "Informe o id do usuário";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(35, 76);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(238, 23);
            txtIdUsuario.TabIndex = 14;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(8, 156, 206);
            btnBuscarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuario.ForeColor = Color.White;
            btnBuscarUsuario.Location = new Point(295, 64);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(87, 41);
            btnBuscarUsuario.TabIndex = 13;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(219, 58, 58);
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(47, 266);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(87, 41);
            btnExcluir.TabIndex = 33;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(37, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            lblEmail.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(37, 161);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 17);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone";
            lblTelefone.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(37, 107);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 22;
            lblNome.Text = "Nome";
            lblNome.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(37, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 17);
            lblId.TabIndex = 21;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(37, 125);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 20;
            txtNome.Visible = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new Point(37, 179);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 19;
            txtTelefone.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(37, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 18;
            txtEmail.Visible = false;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(37, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 23);
            txtID.TabIndex = 17;
            txtID.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(66, 66, 66);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(155, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 40);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 118);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(lblDados);
            Controls.Add(lblInformeUsuario);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnBuscarUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Excluir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excluir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDados;
        private Label lblInformeUsuario;
        private TextBox txtIdUsuario;
        private Button btnBuscarUsuario;
        private Button btnExcluir;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtID;
        private Button btnCancelar;
    }
}