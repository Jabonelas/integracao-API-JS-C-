namespace Projeto_Teste
{
    partial class Atualizar
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblDados = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            lblInformeUsuario = new Label();
            txtIdUsuario = new TextBox();
            btnBuscarUsuario = new Button();
            lblID = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(70, 202, 27);
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(54, 276);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 40);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Visible = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(66, 66, 66);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(182, 276);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 40);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDados.Location = new Point(46, 6);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(185, 32);
            lblDados.TabIndex = 31;
            lblDados.Text = "Buscar Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(54, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email";
            lblEmail.Visible = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(54, 154);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 17);
            lblTelefone.TabIndex = 29;
            lblTelefone.Text = "Telefone";
            lblTelefone.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(54, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 28;
            lblNome.Text = "Nome";
            lblNome.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(54, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 27;
            txtNome.Visible = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(54, 172);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 26;
            txtTelefone.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 25;
            txtEmail.Visible = false;
            // 
            // lblInformeUsuario
            // 
            lblInformeUsuario.AutoSize = true;
            lblInformeUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformeUsuario.Location = new Point(12, 52);
            lblInformeUsuario.Name = "lblInformeUsuario";
            lblInformeUsuario.Size = new Size(156, 17);
            lblInformeUsuario.TabIndex = 36;
            lblInformeUsuario.Text = "Informe o id do Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(12, 70);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(178, 23);
            txtIdUsuario.TabIndex = 35;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(8, 156, 206);
            btnBuscarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuario.ForeColor = Color.White;
            btnBuscarUsuario.Location = new Point(221, 60);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(87, 41);
            btnBuscarUsuario.TabIndex = 37;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(54, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 17);
            lblID.TabIndex = 39;
            lblID.Text = "ID";
            lblID.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(54, 70);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(213, 23);
            txtID.TabIndex = 38;
            txtID.Visible = false;
            // 
            // Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 118);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(lblInformeUsuario);
            Controls.Add(txtIdUsuario);
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
            Name = "Atualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblDados;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblInformeUsuario;
        private TextBox txtIdUsuario;
        private Button btnBuscarUsuario;
        private Label lblID;
        private TextBox txtID;
    }
}