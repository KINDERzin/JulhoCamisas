using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarItemEstoque : ContentPage
    {
        public CadastrarItemEstoque()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string type = typeEntry.Text;
            string quantity = quantityEntry.Text;
            string supplier = supplierEntry.Text;

            // Adicione a lógica de validação e cadastro do item de estoque aqui

            await DisplayAlert("Cadastro", "Item de estoque cadastrado com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            await Navigation.PopAsync();
        }
    }
}
