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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
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

        private void ConfirmacaoEnvio()
        {
            MessageBox.Show("Cadastro Inserido com sucesso!", "Sucesso");

            LimparDados();
        }

        private async void InserirCadastro()
        {
            DadosUsuario DadosUsuario = new DadosUsuario();
            ConexaoAPI conexaoAPI = new ConexaoAPI();

            DadosUsuario.name = txtNome.Text;
            DadosUsuario.phone = txtTelefone.Text;
            DadosUsuario.email = txtEmail.Text;

            await conexaoAPI.InserirDadosAPI(DadosUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente Deseja Cancelar o Cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                LimparDados();
            }
        }

        private void LimparDados()
        {
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }
    }
}