using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class EntregaProduto : ContentPage
    {
        public EntregaProduto()
        {
            InitializeComponent();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            string produto = produtoEntry.Text;
            string endereco = enderecoEntry.Text;
            string numeroCasa = numeroCasaEntry.Text;
            string nome = nomeEntry.Text;

            bool sucesso = await ConfirmarEntregaAsync(produto, endereco, numeroCasa, nome);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Entrega confirmada com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao confirmar a entrega.", "OK");
            }
        }

        private async Task<bool> ConfirmarEntregaAsync(string produto, string endereco, string numeroCasa, string nome)
        {
            return await Task.FromResult(true);
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}