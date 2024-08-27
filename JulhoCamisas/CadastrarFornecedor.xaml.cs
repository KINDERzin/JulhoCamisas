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

        private async void OnConfirmClicked(object sender, EventArgs e)
        {

            var fornecedor = new Modelos.Fornecedor();

            fornecedor.Nome = nomeEntry.Text;
            fornecedor.Telefone = telefoneEntry.Text;
            fornecedor.Endereco = enderecoEntry.Text;
            fornecedor.Cnpj = cnpjEntry.Text;
            fornecedor.Produto = produtoEntry.Text;

            string name = nomeEntry.Text;
            string telefone = telefoneEntry.Text;
            string address = enderecoEntry.Text;
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
