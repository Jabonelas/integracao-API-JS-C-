using Newtonsoft.Json;
using Projeto_Teste.QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    internal class ConexaoAPI
    {
        private DadosUsuario temperatures = new DadosUsuario();

        public async Task BuscarDadosAPI(string _cep)
        {
            try
            {
                HttpClient cliente = new HttpClient { BaseAddress = new Uri($"http://localhost:3000?id={_cep}") };
                var response = await cliente.GetAsync(string.Empty);
                var content = await response.Content.ReadAsStringAsync();

                var users = JsonConvert.DeserializeObject<DadosUsuario>(content);

                temperatures = users;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro ao Buscar Cadastro Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InserirDadosAPI(DadosUsuario _dadosUsuario)
        {
            try
            {
                // Dados do usuário
                var dadosUsuario = new DadosUsuario
                {
                    name = _dadosUsuario.name,
                    email = _dadosUsuario.email,
                    phone = _dadosUsuario.phone
                };

                // Serializa o objeto em formato JSON
                string jsonData = JsonConvert.SerializeObject(dadosUsuario);

                // Crie o conteúdo da requisição a partir dos dados serializados
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Faça a requisição HTTP usando o método PostAsync
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri("http://localhost:3000/inserir"); // URL da sua API

                    // Execute a requisição POST com o conteúdo no corpo
                    var response = await cliente.PostAsync("/inserir", content);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro ao Inserir Cadastro Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task AtualizarDadosAPI(DadosUsuario _dadosUsuario)
        {
            try
            {
                // Dados do usuário
                var dadosUsuario = new DadosUsuario
                {
                    id = _dadosUsuario.id,
                    name = _dadosUsuario.name,
                    email = _dadosUsuario.email,
                    phone = _dadosUsuario.phone
                };

                // Serializa o objeto em formato JSON
                string jsonData = JsonConvert.SerializeObject(dadosUsuario);

                // Crie o conteúdo da requisição a partir dos dados serializados
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Faça a requisição HTTP usando o método PostAsync
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri("http://localhost:3000/atualizar"); // URL da sua API

                    // Execute a requisição POST com o conteúdo no corpo
                    var response = await cliente.PostAsync("/atualizar", content);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro ao Atualizar Cadastro Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ExcluirDadosAPI(DadosUsuario _dadosUsuario)
        {
            try
            {
                // Dados do usuário
                var dadosUsuario = new DadosUsuario
                {
                    id = _dadosUsuario.id,
                    name = _dadosUsuario.name,
                    email = _dadosUsuario.email,
                    phone = _dadosUsuario.phone
                };

                // Serializa o objeto em formato JSON
                string jsonData = JsonConvert.SerializeObject(dadosUsuario);

                // Crie o conteúdo da requisição a partir dos dados serializados
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Faça a requisição HTTP usando o método PostAsync
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri("http://localhost:3000/excluir"); // URL da sua API

                    // Execute a requisição POST com o conteúdo no corpo
                    var response = await cliente.PostAsync("/excluir", content);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro ao Excluir Cadastro Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DadosUsuario RetornoApi()
        {
            return temperatures;
        }
    }
}