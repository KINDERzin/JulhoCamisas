using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class PerfilFornecedor : ContentPage
    {
        public PerfilFornecedor()
        {
            InitializeComponent();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar o fornecedor
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar
            Navigation.PopAsync();
        }
    }
}
