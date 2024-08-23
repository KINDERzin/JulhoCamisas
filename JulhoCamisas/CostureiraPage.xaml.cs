using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Costureira : ContentPage
    {
        public Costureira()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string address = AddressEntry.Text;
            string email = EmailEntry.Text;

            // Adicione a lógica para atualizar as informações da costureira aqui

            await DisplayAlert("Sucesso", "Dados confirmados com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
