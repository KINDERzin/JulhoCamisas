using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarCostureira : ContentPage
    {
        public CadastrarCostureira()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string type = TypeEntry.Text;
            string quantity = QuantityEntry.Text;
            string supplier = SupplierEntry.Text;
            string id = IdEntry.Text;

            // Adicione a lógica para registrar a costureira aqui

            await DisplayAlert("Sucesso", "Costureira cadastrada com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
