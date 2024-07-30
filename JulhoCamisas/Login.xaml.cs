using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Adicione sua lógica de autenticação aqui

            await DisplayAlert("Login", "Login confirmado!", "OK");
        }

        private async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para criar uma nova conta aqui
            await DisplayAlert("Conta", "Criar nova conta", "OK");
        }
    }
}
