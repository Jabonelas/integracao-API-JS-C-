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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
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

                ExibirCampos(true);

                lblDados.Text = "Excluir Dados";
                this.Size = new Size(305, 365);
            }
            else
            {
                MessageBox.Show("ID não encontrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente Deseja Excluir o Cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                lblDados.Text = "Buscar Usuário";
                this.Size = new Size(430, 157);

                ExibirCampos(false);

                DadosUsuario dadosUsuario = new DadosUsuario();

                dadosUsuario.id = txtID.Text;

                ConexaoAPI conexaoAPI = new ConexaoAPI();

                await conexaoAPI.ExcluirDadosAPI(dadosUsuario);

                MessageBox.Show("Cadastro Excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExibirCampos(bool _isExibir)
        {
            txtEmail.Visible = _isExibir;
            txtNome.Visible = _isExibir;
            txtTelefone.Visible = _isExibir;
            txtID.Visible = _isExibir;
            btnExcluir.Visible = _isExibir;
            btnCancelar.Visible = _isExibir;
            lblEmail.Visible = _isExibir;
            lblNome.Visible = _isExibir;
            lblTelefone.Visible = _isExibir;
            lblId.Visible = _isExibir;

            btnBuscarUsuario.Visible = !_isExibir;
            txtIdUsuario.Visible = !_isExibir;
            lblInformeUsuario.Visible = !_isExibir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente Deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                lblDados.Text = "Buscar Usuário";
                this.Size = new Size(430, 157);

                ExibirCampos(false);
            }
        }
    }
}