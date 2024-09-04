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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (costureira != null)
            {
            labelIdCostureira.IsVisible = true;
            labelId.IsVisible = true;
            deleteButton.IsVisible = true;

            labelTitulo.Text = "Editar funcionário";
            
            labelIdCostureira.Text = costureira.Id.ToString();
            NomeEntry.Text = costureira.Nome; 
            EnderecoEntry.Text = costureira.Endereco;
            TelefoneEntry.Text = costureira.Telefone;
            CpfEntry.Text = costureira.Cpf;
            }
        }

        private async void DeletarClicked(object sender, EventArgs e)
        {
            costureiraControle.Apagar(costureira.Id);

            await DisplayAlert("Deletar", "Costureira deletada com sucesso", "Ok");
            Application.Current.MainPage = new ListaCostureiraPage();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            var costureira = new Modelos.Costureira();

            costureira.Nome = NomeEntry.Text; 
            costureira.Endereco = EnderecoEntry.Text;
            costureira.Telefone = TelefoneEntry.Text;
            costureira.Cpf = CpfEntry.Text;

            if (String.IsNullOrEmpty(NomeEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            }

            else if (String.IsNullOrEmpty(EnderecoEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
            }

            else if (String.IsNullOrEmpty(TelefoneEntry.Text)){
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            }

            else if (String.IsNullOrEmpty(CpfEntry.Text)){
                await DisplayAlert("Cadastrar", "O campo Cpf é obrigatório", "Ok");
            }

            else{
                costureiraControle.CriarOuAtualizar(costureira);
                await DisplayAlert("CONCLUÍDO","Funcionário cadastrado com sucesso","OK");
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaCostureiraPage();
        }
    }
}
