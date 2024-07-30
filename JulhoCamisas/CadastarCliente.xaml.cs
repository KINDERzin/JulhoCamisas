using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarCliente : ContentPage
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private async void OnConfirmDataClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;
            string address = addressEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            // Adicione a lógica de validação e registro aqui

            await DisplayAlert("Cadastro", "Dados confirmados!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            await Navigation.PopAsync();
        }
    }
}
