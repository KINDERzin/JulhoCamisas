using Controles;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Acabamento : ContentPage
    {

        Acabamento acabamento;
        AcabamentoControle acabamentoControle;

        public Acabamento()
        {
            InitializeComponent();

            acabamento = new Acabamento();
            acabamentoControle = new AcabamentoControle();
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
            TipoEntry.Text = acabamento.Tipo;
            CorEntry.Text = acabamento.Cor;
            FornecedorEntry.Text = acabamento.Fornecedor;
            QuantidadeEntry.Text = acabamento.Quantidade;

            TipoEntry.IsEnabled = false;
            CorEntry.IsEnabled = false;            
            QuantidadeEntry.IsEnabled = false;
            FornecedorEntry.IsEnabled = false;

            if(TipoEntry.Text == string.Empty || CorEntry.Text == string.Empty || FornecedorEntry.Text == string.Empty || QuantidadeEntry.Text == string.Empty)
            {
                await DisplayAlert("Erro", "Os campos acima estão vazios.", "OK");
            }
            else{
                bool sucesso = await AtualizarAcabamentoAsync(Tipo, Cor, Quantidade, Fornecedor);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Acabamento atualizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao atualizar o acabamento.", "OK");
            }
            }

            // Lógica para atualizar o acabamento (chamar sua API ou serviço)
            
        }

        private async Task<bool> AtualizarAcabamentoAsync(string tipo, string cor, string quantidade, string fornecedor)
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