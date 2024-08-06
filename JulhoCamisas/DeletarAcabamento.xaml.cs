using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class DeletarAcabamento : ContentPage
    {
        public DeletarAcabamento()
        {
            InitializeComponent();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string acabamento = acabamentoEntry.Text;
            string senha = senhaEntry.Text;

            // Lógica para deletar o acabamento (chamar sua API ou serviço)
            bool sucesso = await DeletarAcabamentoAsync(acabamento, senha);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Acabamento deletado com sucesso!", "OK");
                // Limpar os campos ou navegar para outra página
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao deletar o acabamento.", "OK");
            }
        }

        private async Task<bool> DeletarAcabamentoAsync(string acabamento, string senha)
        {
            // Implemente aqui a lógica para deletar o acabamento
            // Chame sua API ou serviço, faça as validações necessárias
            // Retorne true se a deleção for bem-sucedida, false caso contrário
            // Exemplo simplificado:
            return await Task.FromResult(true); // Substitua por sua lógica real

            // **Importante:** Substitua este método pela sua lógica real de deleção,
            // que pode envolver chamadas a uma API, banco de dados, etc.

            
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }
    }
}