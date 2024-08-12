using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class DeletarCostureira : ContentPage
    {
        public DeletarCostureira()
        {
            InitializeComponent();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string nomeCostureira = nomeCostureiraEntry.Text;
            string senha = senhaEntry.Text;

            // Lógica para excluir a costureira (chamar sua API ou serviço)
            bool sucesso = await ExcluirCostureiraAsync(nomeCostureira, senha);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Costureira excluída com sucesso!", "OK");
                // Navegar para outra página ou fechar a modal
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao excluir a costureira.", "OK");
            }
        }

        private async Task<bool> ExcluirCostureiraAsync(string nome, string senha)
        {
            // Implemente aqui a lógica para excluir a costureira
            // Chame sua API ou serviço, faça as validações necessárias
            // Retorne true se a exclusão for bem-sucedida, false caso contrário
            // Exemplo simplificado:
            return await Task.FromResult(true); // Substitua por sua lógica real

            // **Importante:** Substitua este método pela sua lógica real de exclusão,
            // que pode envolver chamadas a uma API, banco de dados, etc.
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }
    }
}