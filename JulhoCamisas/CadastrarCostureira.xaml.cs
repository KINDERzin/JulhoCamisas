using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarCostureira : ContentPage
    {

        public Costureira costureira{ get; set; }

        public CadastrarCostureira()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string endereco = EnderecoEntry.Text;
            string email = EmailEntry.Text;
            string cpf = CpfEntry.Text;

            // Adicione a lógica para registrar a costureira aqui

            await DisplayAlert("Sucesso", "Costureira cadastrada com sucesso!", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaCostureiraPage();
        }
    }
}
