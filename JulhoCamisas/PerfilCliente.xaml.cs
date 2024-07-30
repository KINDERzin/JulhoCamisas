using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class PerfilCliente : ContentPage
    {
        public PerfilCliente()
        {
            InitializeComponent();
        }

        private void OnEditNameClicked(object sender, EventArgs e)
        {
            nameEntry.IsReadOnly = false;
            nameEntry.Focus();
        }

        private void OnEditEmailClicked(object sender, EventArgs e)
        {
            emailEntry.IsReadOnly = false;
            emailEntry.Focus();
        }

        private void OnEditAddressClicked(object sender, EventArgs e)
        {
            addressEntry.IsReadOnly = false;
            addressEntry.Focus();
        }

        private void OnEditPasswordClicked(object sender, EventArgs e)
        {
            passwordEntry.IsReadOnly = false;
            passwordEntry.Focus();
        }

        private async void OnDeleteAccountClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Excluir Conta", "Você tem certeza que deseja excluir sua conta?", "Sim", "Não");
            if (answer)
            {
                // Adicione a lógica para excluir a conta aqui
                await DisplayAlert("Conta Excluída", "Sua conta foi excluída com sucesso!", "OK");
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            await Navigation.PopAsync();
        }
    }
}
