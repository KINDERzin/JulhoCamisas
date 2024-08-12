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
            // Habilitar edição do campo correspondente
            if (sender is Button button)
            {
                clienteEntry.IsEnabled = true;
            }
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string cliente = clienteEntry.Text;
            string produto = produtoEntry.Text;
            int quantidade = int.Parse(quantidadeEntry.Text);

            // Lógica para atualizar o relatório de vendas (chamar sua API ou serviço)
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
            // Implemente aqui a lógica para atualizar o relatório de vendas
            // Chame sua API ou serviço, faça as validações necessárias
            // Retorne true se a atualização for bem-sucedida, false caso contrário
            // Exemplo simplificado:
             return await Task.FromResult(true); // Substitua por sua lógica real
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}