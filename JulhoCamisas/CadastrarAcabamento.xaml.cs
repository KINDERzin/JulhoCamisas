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
        }

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            
            tipoEntry.Text = acabamento.Tipo;
            corEntry.Text = acabamento.Cor;
            quantidadeEntry.Text = acabamento.Quantidade;
            fornecedorEntry.Text = acabamento.Fornecedor;

            await DisplayAlert("Sucesso", "Acabamento cadastrado com sucesso!", "OK");

        }

        

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Application.Current.MainPage = new ListaAcabamentoPage();
        }
    }
}