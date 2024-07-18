using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCEP.Model;
using Newtonsoft.Json;

namespace AppCEP.ViewModel
{
	internal class ViaCEPServico
	{
		// Propriedada para armazenar o endereço do serviço da API
		private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

		public static Endereco BuscarEnderecoCEP(string cep)
		{
			// Concatena o endereço do serviço com o CEP digitado
			String NovoEnderecoURL = string.Format(EnderecoURL, cep);

			// Cria um objeto HttpClient para uma conexão com a internet
			HttpClient hc = new HttpClient();
			// Faz a requisição do conteúdo do endereço na API
			string Conteudo = hc.GetStringAsync(NovoEnderecoURL).Result;

			// Deserializa o conteúdo da API para um objeto Endereco
			Endereco endereco = JsonConvert.DeserializeObject<Endereco>(Conteudo);

			return endereco;

		}




	}
}
