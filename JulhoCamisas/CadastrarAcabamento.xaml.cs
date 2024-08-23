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

        private async void Confirmar_Clicked(object sender, EventArgs e)
        {
            var acabamento = new Modelos.Acabamento();

            acabamento.Cor = corEntry.Text;
            acabamento.Quantidade = quantidadeEntry.Text;
            acabamento.Fornecedor = fornecedorEntry.Text;
            acabamento.Tipo = tipoEntry.Text;
            
            corEntry.Text = acabamento.Cor;
            quantidadeEntry.Text = acabamento.Quantidade;
            fornecedorEntry.Text = acabamento.Fornecedor;
            tipoEntry.Text = acabamento.Tipo;

            acabamentoControle.CriarOuAtualizar(acabamento);

            await DisplayAlert("Sucesso", "Acabamento cadastrado com sucesso!", "OK");

        }

        

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaAcabamentoPage();
        }
    }
}