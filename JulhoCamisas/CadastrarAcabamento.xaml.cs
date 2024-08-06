using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarAcabamento : ContentPage
    {
        public CadastrarAcabamento()
        {
            InitializeComponent();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string tipo = tipoEntry.Text;
            string cor = corEntry.Text;
            int quantidade = int.Parse(quantidadeEntry.Text);
            string fornecedor = fornecedorEntry.Text;

            // Lógica para cadastrar o acabamento (chamar sua API ou serviço)
            bool sucesso = await CadastrarAcabamentoAsync(tipo, cor, quantidade, fornecedor);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Acabamento cadastrado com sucesso!", "OK");
                // Limpar os campos ou navegar para outra página
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao cadastrar o acabamento.", "OK");
            }
        }

        private async Task<bool> CadastrarAcabamentoAsync(string tipo, string cor, int quantidade, string fornecedor)
        {
            // Implemente aqui a lógica para cadastrar o acabamento
            // Chame sua API ou serviço, faça as validações necessárias
            // Retorne true se o cadastro for bem-sucedido, false caso contrário
            // Exemplo simplificado:
             return await Task.FromResult(true); // Substitua por sua lógica real

            // **Importante:** Substitua este método pela sua lógica real de cadastro,
            // que pode envolver chamadas a uma API, banco de dados, etc.
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }
    }
}