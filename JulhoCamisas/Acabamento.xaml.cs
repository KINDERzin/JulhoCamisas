using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Acabamento : ContentPage
    {
        public Acabamento()
        {
            InitializeComponent();
        }

        private async void Editar_Clicked(object sender, EventArgs e)
        {
            // Habilitar edição do campo correspondente
            if (sender is Button button)
            {
                var entry = tipoEntry.Text;
            }
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string tipo = tipoEntry.Text;
            string cor = corEntry.Text;
            int quantidade = int.Parse(quantidadeEntry.Text);

            // Lógica para atualizar o acabamento (chamar sua API ou serviço)
            bool sucesso = await AtualizarAcabamentoAsync(tipo, cor, quantidade);

            if (sucesso)
            {
                await DisplayAlert("Sucesso", "Acabamento atualizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Erro ao atualizar o acabamento.", "OK");
            }
        }

        private async Task<bool> AtualizarAcabamentoAsync(string tipo, string cor, int quantidade)
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