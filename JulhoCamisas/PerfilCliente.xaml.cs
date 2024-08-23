using Controles;
using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class PerfilCliente : ContentPage
    {

        public Modelos.Cliente cliente;
        public PerfilCliente perfilCliente;
        ClienteControle clienteControle;

        public PerfilCliente()
        {
            InitializeComponent();

            var cliente = new Modelos.Cliente();

        }
    
        private async void editarNome_Clicked(object sender, EventArgs e)
        {
            nomeEntry.IsEnabled = true;
        }

        private async void editarSobrenome_Clicked(object sender, EventArgs e)
        {
            sobrenomeEntry.IsEnabled = true;
        }

        private async void editarCpf_Clicked(object sender, EventArgs e)
        {
            cpfEntry.IsEnabled = true;
        }

        private async void editarTelefone_Clicked(object sender, EventArgs e)
        {
            telefoneEntry.IsEnabled = true;
        }

        private async void Salvar_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            nomeEntry.Text = cliente.Nome;
            sobrenomeEntry.Text = cliente.Sobrenome;
            cpfEntry.Text = cliente.Cpf;
            telefoneEntry.Text = cliente.Telefone;

            nomeEntry.IsEnabled = false;
            sobrenomeEntry.IsEnabled = false;            
            cpfEntry.IsEnabled = false;
            telefoneEntry.IsEnabled = false;

            if(nomeEntry.Text == string.Empty || sobrenomeEntry.Text == string.Empty || cpfEntry.Text == string.Empty || telefoneEntry.Text == string.Empty)
            {
                await DisplayAlert("Erro", "Os campos acima estão vazios.", "OK");
            }
            else{
                await DisplayAlert("CONCUÍDO", "Os dados foram salvos", "Ok");
            }
        }

        private async void clicouBotaoExcluirConta(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Excluir Conta", "Você tem certeza que deseja excluir sua conta?", "Sim", "Não");
            if (answer)
            {
                // Adicione a lógica para excluir a conta aqui
                await DisplayAlert("Conta Excluída", "Sua conta foi excluída com sucesso!", "OK");
            }
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientesPage();
        }
    }
}
