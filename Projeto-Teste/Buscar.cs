using Projeto_Teste.QuickType;

namespace Projeto_Teste
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
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

                lblDados.Text = "Dados do Usuário";
                this.Size = new Size(300, 377);
            }
            else
            {
                MessageBox.Show("ID não encontrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExibirCampos(bool _isExibir)
        {
            txtEmail.Visible = _isExibir;
            txtNome.Visible = _isExibir;
            txtTelefone.Visible = _isExibir;
            txtID.Visible = _isExibir;
            btnVoltar.Visible = _isExibir;
            lblEmail.Visible = _isExibir;
            lblNome.Visible = _isExibir;
            lblTelefone.Visible = _isExibir;
            lblId.Visible = _isExibir;

            btnBuscarUsuario.Visible = !_isExibir;
            txtIdUsuario.Visible = !_isExibir;
            lblInformeUsuario.Visible = !_isExibir;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lblDados.Text = "Buscar Usuário";
            this.Size = new Size(430, 157);

            ExibirCampos(false);
        }
    }
}