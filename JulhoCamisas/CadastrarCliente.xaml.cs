using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarCliente : ContentPage
    {

        public Cliente cliente {get ; set;}
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private async void OnConfirmDataClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;
            string address = addressEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            // Adicione a lógica de validação e registro aqui

            await DisplayAlert("Cadastro", "Dados confirmados!", "OK");
        }

        

        void VoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientesPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
            IdLabel.Text = Cliente.Id.ToString();
            NomeEntry.Text = Cliente.Nome;
            SobrenomeEntry.Text = Cliente.Sobrenome;
            TelefoneEntry.Text = Cliente.Telefone;
            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            IdLabel.Text = string.Empty;
            NomeEntry.Text = string.Empty;
            SobrenomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
        }

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
            var cliente = new Modelos.Cliente();
            cliente.Id   = int.Parse(IdLabel.Text);
            cliente.Nome = NomeEntry.Text;
            cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;

            clienteControle.CriarOuAtualizar(cliente);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
            }
            else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
            return false;
            }
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
            }
            else
            return true;
        }
    }
}
