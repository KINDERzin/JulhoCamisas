using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarFornecedor : ContentPage
    {

        public Fornecedor fornecedor{ get; set; }
        public Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private async void OnConfirmDataClicked(object sender, EventArgs e)
        {

            var fornecedor = new Modelos.Fornecedor();

            fornecedor.Nome = nameEntry.Text;
            fornecedor.Telefone = telefoneEntry.Text;
            fornecedor.Endereco = addressEntry.Text;
            fornecedor.Cnpj = cnpjEntry.Text;
            fornecedor.Produto = produtoEntry.Text;

            string name = nameEntry.Text;
            string telefone = telefoneEntry.Text;
            string address = addressEntry.Text;
            string cnpj = cnpjEntry.Text;
            string produto  = produtoEntry.Text;

            fornecedorControle.CriarOuAtualizar(fornecedor);

            await DisplayAlert("Cadastro", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }
    }
}
