using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class FinalizarCompra : ContentPage
    {
        public FinalizarCompra()
        {
            InitializeComponent();
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            string numeroCamisa = numeroCamisaEntry.Text;
            string confirmacao = confirmarEntry.Text;

            bool sucesso = await FinalizarCompraAsync(numeroCamisa, confirmacao);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Compra realizada com sucesso!", "OK");
                
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao finalizar a compra.", "OK");
            }
        }

        private async Task<bool> FinalizarCompraAsync(string numeroCamisa, string confirmacao)
        {
            return await Task.FromResult(true);
        }
    }
}