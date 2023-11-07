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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar form = new Buscar();
            form.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar atualizar = new Atualizar();
            atualizar.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.ShowDialog();
        }
    }
}