using JulhoCamisas.Modelos;
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
            
            string name = NomeEntry.Text;
            string sobrenome = SobrenomeEntry.Text;
            string email = CpfEntry.Text;
            string telefone = TelefoneEntry.Text;
            string address = EnderecoEntry.Text;

            // Adicione a lógica de validação e registro aqui

            await DisplayAlert("Cadastro", "Dados confirmados!", "OK");
        }
        void VoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientesPage();
        }

        async void DeletarClicked(object sender, EventArgs e)
        {
            clienteControle.Apagar(cliente.Id);

             await DisplayAlert("Deletar", "Cliente deletado!", "OK");
             Application.Current.MainPage = new ListaClientesPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                
            labelIdCliente.IsVisible = true;
            labelId.IsVisible = true;
            labelTitulo.Text = "Editar cliente";
            labelIdCliente.Text = cliente.Id.ToString(); 
            NomeEntry.Text = cliente.Nome;
            SobrenomeEntry.Text = cliente.Sobrenome;
            TelefoneEntry.Text = cliente.Telefone;
            CpfEntry.Text = cliente.Cpf;
            EnderecoEntry.Text = cliente.Endereco;
            }
        }

        async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            
            var cliente = new Modelos.Cliente();

            if (!String.IsNullOrEmpty(labelIdCliente.Text))
                cliente.Id = int.Parse(labelIdCliente.Text);
            else
                cliente.Id = 0;
                
            cliente.Nome = NomeEntry.Text;
            cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;
            cliente.Cpf = CpfEntry.Text;
            cliente.Endereco = EnderecoEntry.Text;

            clienteControle.CriarOuAtualizar(cliente);

            if (String.IsNullOrEmpty(NomeEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            }

            else if (String.IsNullOrEmpty(SobrenomeEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
            }

            else if (String.IsNullOrEmpty(TelefoneEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            }

            else if (!String.IsNullOrEmpty(CpfEntry.Text)){
                await DisplayAlert("Cadastrar", "O campo Cpf é obrigatório", "Ok");
            }

            else if (!String.IsNullOrEmpty(EnderecoEntry.Text)){
                await DisplayAlert("Cadastrar", "O campo Endereco é obrigatório", "Ok");
            }
            else{
                 await DisplayAlert("CONCLUÍDO","Dados salvos com sucesso","OK");
            }
           
            
            
        }
    }
}
