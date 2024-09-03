using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarFornecedor : ContentPage
    {

        public Modelos.Fornecedor fornecedor{ get; set; }
        public Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
            labelIdFornecedor.IsVisible = true;
            labelId.IsVisible = true;
            deleteButton.IsVisible = true;

            labelTitulo.Text = "Editar fornecedor";
            
            labelIdFornecedor.Text = fornecedor.Id.ToString();
            nomeEntry.Text = fornecedor.Nome; 
            telefoneEntry.Text = fornecedor.Telefone;
            enderecoEntry.Text = fornecedor.Endereco;
            cnpjEntry.Text = fornecedor.Cnpj;
            produtoEntry.Text = fornecedor.Produto;
            }
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {

            var fornecedor = new Modelos.Fornecedor();

            fornecedor.Nome = nomeEntry.Text;
            fornecedor.Telefone = telefoneEntry.Text;
            fornecedor.Endereco = enderecoEntry.Text;
            fornecedor.Cnpj = cnpjEntry.Text;
            fornecedor.Produto = produtoEntry.Text;

            fornecedorControle.CriarOuAtualizar(fornecedor);

            await DisplayAlert("Cadastro", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }

        private async void DeletarClicked(object sender, EventArgs e)
        {
            fornecedorControle.Apagar(fornecedor.Id);

            await DisplayAlert("Deletar", "Fornecedor deletado com sucesso", "Ok");
            Application.Current.MainPage =  new ListaFornecedorPage();
        }
    }
}
