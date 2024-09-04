using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class RelatorioDeVendas : ContentPage
    {
        public RelatorioDeVendas()
        {
            InitializeComponent();
        }

        private void Editar_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                clienteEntry.IsEnabled = true;
            }
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            string cliente = clienteEntry.Text;
            string produto = produtoEntry.Text;
            int quantidade = int.Parse(quantidadeEntry.Text);

            bool sucesso = await AtualizarRelatorioVendasAsync(cliente, produto, quantidade);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Relatório de vendas atualizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao atualizar o relatório de vendas.", "OK");
            }
        }

        private async Task<bool> AtualizarRelatorioVendasAsync(string cliente, string produto, int quantidade)
        {
             return await Task.FromResult(true);
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}