using Controles;
using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class AcabamentoPage : ContentPage
    {

        public Modelos.Acabamento acabamento;
        public AcabamentoPage acabamentoPage;
        AcabamentoControle acabamentoControle;
        ListaAcabamentoPage listaAcabamentoPage = new ListaAcabamentoPage();
        
        public AcabamentoPage()
        {
            InitializeComponent();  

            acabamento = new Acabamento();
            acabamentoControle = new AcabamentoControle();
        }

        private async void EditarTipo_Clicked(object sender, EventArgs e)
        {
            TipoEntry.IsEnabled = true;
        }

        private async void EditarCor_Clicked(object sender, EventArgs e)
        {
            CorEntry.IsEnabled = true;
        }

        private async void EditarQuantidade_Clicked(object sender, EventArgs e)
        {
            QuantidadeEntry.IsEnabled = true;
        }

        private async void EditarFornecedor_Clicked(object sender, EventArgs e)
        {
            FornecedorEntry.IsEnabled = true;
        }

        private async void Salvar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            TipoEntry.Text = acabamento.Tipo;
            CorEntry.Text = acabamento.Cor;
            FornecedorEntry.Text = acabamento.Fornecedor;
            QuantidadeEntry.Text = acabamento.Quantidade;

            TipoEntry.IsEnabled = false;
            CorEntry.IsEnabled = false;            
            QuantidadeEntry.IsEnabled = false;
            FornecedorEntry.IsEnabled = false;

            if(TipoEntry.Text == string.Empty || CorEntry.Text == string.Empty || FornecedorEntry.Text == string.Empty || QuantidadeEntry.Text == string.Empty)
            {
                await DisplayAlert("Erro", "Os campos acima estão vazios.", "OK");
            }
            else{
                await DisplayAlert("CONCUÍDO", "Os dados foram salvos", "Ok");
            }
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaAcabamentoPage();
        }
    }
}