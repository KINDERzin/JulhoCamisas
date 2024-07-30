using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class EntregaProduto : ContentPage
    {
        public EntregaProduto()
        {
            InitializeComponent();
        }

        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string produto = produtoEntry.Text;
            string endereco = enderecoEntry.Text;
            string numeroCasa = numeroCasaEntry.Text;
            string nome = nomeEntry.Text;

            // Lógica para confirmar a entrega (chamar sua API ou serviço)
            bool sucesso = await ConfirmarEntregaAsync(produto, endereco, numeroCasa, nome);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Entrega confirmada com sucesso!", "OK");
                // Limpar os campos ou navegar para outra página
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao confirmar a entrega.", "OK");
            }
        }

        private async Task<bool> ConfirmarEntregaAsync(string produto, string endereco, string numeroCasa, string nome)
        {
            // Implemente aqui a lógica para confirmar a entrega
            // Chame sua API ou serviço, faça as validações necessárias
            // Retorne true se a confirmação for bem-sucedida, false caso contrário
            // Exemplo simplificado:
            // return await Task.FromResult(true); // Substitua por sua lógica real

            // **Importante:** Substitua este método pela sua lógica real de confirmação da entrega,
            // que pode envolver chamadas a uma API, banco de dados, etc.
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }
    }
}