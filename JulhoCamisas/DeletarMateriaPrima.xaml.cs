using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class DeletarMateriaPrima : ContentPage
    {
        public DeletarMateriaPrima()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string type = typeEntry.Text;
            string supplier = supplierEntry.Text;
            string password = passwordEntry.Text;

            // Adicione a lógica de autenticação e deleção de matéria prima aqui

            bool isDeleted = await DeleteRawMaterial(type, supplier, password);

            if (isDeleted)
            {
                await DisplayAlert("Sucesso", "Matéria prima deletada com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Não foi possível deletar a matéria prima. Verifique suas credenciais.", "OK");
            }
        }

        private Task<bool> DeleteRawMaterial(string type, string supplier, string password)
        {
            // Adicione a lógica para deletar a matéria prima e retornar true se for bem-sucedido, false caso contrário
            // Isso é apenas um exemplo, substitua pela lógica real
            return Task.FromResult(true);
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para voltar à página anterior aqui
            await Navigation.PopAsync();
        }
    }
}
