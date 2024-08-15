using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Acabamento : ContentPage
    {
        public Acabamento()
        {
            InitializeComponent();
        }

        private async void EditarTipo_Clicked(object sender, EventArgs e)
        {
            TipoEntry.IsEnabled = true;
        }

        private async void EditarCor_Clicked(object sender, EventArgs e)
        {
            CorEntry.IsEnabled = true;
        }

        private async void EditarQuantidade_Clicked(object sender, EventArgs e)
        {
            QuantidadeEntry.IsEnabled = true;
        }

        private async void EditarFornecedor_Clicked(object sender, EventArgs e)
        {
            FornecedorEntry.IsEnabled = true;
        }

        private async void Salvar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string tipo = TipoEntry.Text;
            string cor = CorEntry.Text;
            string fornecedor = FornecedorEntry.Text;
            int quantidade = int.Parse(QuantidadeEntry.Text);

            TipoEntry.IsEnabled = false;
            CorEntry.IsEnabled = true;            
            QuantidadeEntry.IsEnabled = true;
            FornecedorEntry.IsEnabled = true;

            // Lógica para atualizar o acabamento (chamar sua API ou serviço)
            bool sucesso = await AtualizarAcabamentoAsync(tipo, cor, quantidade, fornecedor);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Acabamento atualizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao atualizar o acabamento.", "OK");
            }
        }

        private async Task<bool> AtualizarAcabamentoAsync(string tipo, string cor, int quantidade, string fornecedor)
        {
            // Implemente aqui a lógica para atualizar o acabamento
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