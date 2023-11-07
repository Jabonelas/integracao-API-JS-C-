using Projeto_Teste.QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente Deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                LimparDados();

                ExibirCampos(true);

                this.Size = new Size(341, 159);
            }
        }

        private void LimparDados()
        {
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdUsuario.Text, out int idUsuario))
            {
                PreencherCampos();
            }
            else
            {
                MessageBox.Show("Por Favor preencher com um ID valido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void PreencherCampos()
        {
            ConexaoAPI dadosUsuario = new ConexaoAPI();

            await dadosUsuario.BuscarDadosAPI(txtIdUsuario.Text);

            var item = dadosUsuario.RetornoApi();

            if (item != null)
            {
                string id = dadosUsuario.RetornoApi().id;
                string nome = dadosUsuario.RetornoApi().name;
                string telefone = dadosUsuario.RetornoApi().phone;
                string email = dadosUsuario.RetornoApi().email;

                txtID.Text = id;
                txtNome.Text = nome;
                txtTelefone.Text = telefone;
                txtEmail.Text = email;

                ExibirCampos(false);

                lblDados.Text = "Atualizar Usuário";

                this.Size = new Size(341, 367);
            }
            else
            {
                MessageBox.Show("ID não encontrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExibirCampos(bool _isExibir)
        {
            txtID.Visible = !_isExibir;
            txtEmail.Visible = !_isExibir;
            txtNome.Visible = !_isExibir;
            txtTelefone.Visible = !_isExibir;
            lblID.Visible = !_isExibir;
            lblEmail.Visible = !_isExibir;
            lblNome.Visible = !_isExibir;
            lblTelefone.Visible = !_isExibir;
            btnCancelar.Visible = !_isExibir;
            btnSalvar.Visible = !_isExibir;

            btnBuscarUsuario.Visible = _isExibir;
            txtIdUsuario.Visible = _isExibir;
            lblInformeUsuario.Visible = _isExibir;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty)
            {
                InserirCadastro();

                ConfirmacaoEnvio();
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Os Campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void InserirCadastro()
        {
            DadosUsuario DadosUsuario = new DadosUsuario();
            ConexaoAPI conexaoAPI = new ConexaoAPI();

            DadosUsuario.id = txtIdUsuario.Text;
            DadosUsuario.name = txtNome.Text;
            DadosUsuario.phone = txtTelefone.Text;
            DadosUsuario.email = txtEmail.Text;

            await conexaoAPI.AtualizarDadosAPI(DadosUsuario);
        }

        private void ConfirmacaoEnvio()
        {
            MessageBox.Show("Atualização realizada com sucesso!", "Sucesso");

            LimparDados();

            ExibirCampos(true);

            this.Size = new Size(341, 159);
        }
    }
}