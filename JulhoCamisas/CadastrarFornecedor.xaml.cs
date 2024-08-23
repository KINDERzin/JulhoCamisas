using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarFornecedor : ContentPage
    {

        public Fornecedor fornecedor{ get; set; }

        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private async void OnConfirmDataClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;
            string address = addressEntry.Text;
            string product = productEntry.Text;
            string quantity = quantityEntry.Text;

            // Adicione a lógica de validação e cadastro do fornecedor aqui

            await DisplayAlert("Cadastro", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }
    }
}
