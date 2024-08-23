using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarAcabamento : ContentPage
    {

        public Acabamento acabamento{ get; set; }

        public CadastrarAcabamento()
        {
            InitializeComponent();

            acabamento = new Acabamento();
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            
            
            corEntry.Text = acabamento.Cor;
            quantidadeEntry.Text = acabamento.Quantidade;
            fornecedorEntry.Text = acabamento.Fornecedor;
            tipoEntry.Text = acabamento.Tipo;

            await DisplayAlert("Sucesso", "Acabamento cadastrado com sucesso!", "OK");

        }

        

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaAcabamentoPage();
        }
    }
}