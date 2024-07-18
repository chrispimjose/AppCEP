using AppCEP.Model;
using AppCEP.ViewModel;

namespace AppCEP
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
			// Atribui os eventos aos botões
			BOTAO.Clicked += BuscarCEP;
			BOTAO2.Clicked += Limpeza;

		}

		private void BuscarCEP(object? sender, EventArgs e)
		{
			//Retira espaços em branco e pega o CEP digitado
			string cep = CEP.Text.Trim();
			// Faz a busca do endereço do CEP
			// através do serviço ViaCEPServico
			Endereco end = ViaCEPServico.BuscarEnderecoCEP(cep);

			// Exibe o resultado
			RESULTADO.Text = "Local: " + end.localidade + " - " + end.uf + " - Endereço: " + end.logradouro + " - Bairro: " + end.bairro;
		}

		private void Limpeza(object? sender, EventArgs e)
		{
			// Limpa a consulta
			CEP.Text = "";
			RESULTADO.Text = "";
		}
	}
}
