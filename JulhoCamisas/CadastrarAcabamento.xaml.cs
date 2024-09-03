using Controles;
using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarAcabamento : ContentPage
    {

        public Acabamento acabamento{ get; set; }
        public AcabamentoControle acabamentoControle = new AcabamentoControle();
        public CadastrarAcabamento()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (acabamento != null)
            {
            labelIdAcabamento.IsVisible = true;
            labelId.IsVisible = true;
            deleteButton.IsVisible = true;

            labelTitulo.Text = "Editar acabamento";
            
            labelIdAcabamento.Text = acabamento.Id.ToString();
            tipoEntry.Text = acabamento.Tipo; 
            corEntry.Text = acabamento.Cor;
            fornecedorEntry.Text = acabamento.Fornecedor;
            quantidadeEntry.Text = acabamento.Quantidade;
            }
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            var acabamento = new Modelos.Acabamento();

            if (!String.IsNullOrEmpty(labelIdAcabamento.Text))
                acabamento.Id = int.Parse(labelIdAcabamento.Text);
            else
                acabamento.Id = 0;

            acabamento.Cor = corEntry.Text;
            acabamento.Quantidade = quantidadeEntry.Text;
            acabamento.Fornecedor = fornecedorEntry.Text;
            acabamento.Tipo = tipoEntry.Text;

            acabamentoControle.CriarOuAtualizar(acabamento);

            await DisplayAlert("Sucesso", "Acabamento cadastrado com sucesso!", "OK");

        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaAcabamentoPage();
        }

        private async void DeletarClicked(object sender, EventArgs e)
        {
            acabamentoControle.Apagar(acabamento.Id);

            await DisplayAlert("Deletar", "Acabamento deletado com sucesso!", "Ok");
            Application.Current.MainPage = new ListaAcabamentoPage();
        }
    }
}