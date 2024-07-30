using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class ExcluirContaCliente : ContentPage
    {
        public ExcluirContaCliente()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Adicione a lógica de autenticação e exclusão de conta aqui

            bool isDeleted = await DeleteAccount(username, password);

            if (isDeleted)
            {
                await DisplayAlert("Conta Excluída", "Sua conta foi excluída com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Não foi possível excluir sua conta. Verifique suas credenciais.", "OK");
            }
        }

        private Task<bool> DeleteAccount(string username, string password)
        {
            // Adicione a lógica para excluir a conta e retornar true se for bem-sucedido, false caso contrário
            // Isso é apenas um exemplo, substitua pela lógica real
            return Task.FromResult(true);
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            await Navigation.PopAsync();
        }
    }
}
