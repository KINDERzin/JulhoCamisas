using Controles;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarCostureira : ContentPage
    {

        public Modelos.Costureira costureira{ get; set; }

        public CostureiraControle costureiraControle = new CostureiraControle();

        public CadastrarCostureira()
        {
            InitializeComponent();
        }

        

        private async void OnConfirmClicked(object sender, EventArgs e)
        {

            var costureira = new Modelos.Costureira();

            costureira.Nome = NomeEntry.Text; 
            costureira.Endereco = EnderecoEntry.Text;
            costureira.Telefone = TelefoneEntry.Text;
            costureira.Cpf = CpfEntry.Text;

            string nome = NomeEntry.Text;
            string endereco = EnderecoEntry.Text;
            string telefone = TelefoneEntry.Text;
            string cpf = CpfEntry.Text;

            costureiraControle.CriarOuAtualizar(costureira);

            await DisplayAlert("Sucesso", "Costureira cadastrada com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaCostureiraPage();
        }
    }
}
