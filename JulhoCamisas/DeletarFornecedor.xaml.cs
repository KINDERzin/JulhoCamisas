using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class DeletarFornecedor : ContentPage
    {
        public DeletarFornecedor()
        {
            InitializeComponent();
        }

        private void OnConfirmarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar a exclusão do fornecedor
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar
            Navigation.PopAsync();
        }
    }
}
