using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class DeletarItemEstoque: ContentPage
    {
        public DeletarItemEstoque()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string item = ItemEntry.Text;
            string password = PasswordEntry.Text;

            // Adicione a lógica para deletar o item do estoque aqui

            await DisplayAlert("Sucesso", "Item deletado com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
