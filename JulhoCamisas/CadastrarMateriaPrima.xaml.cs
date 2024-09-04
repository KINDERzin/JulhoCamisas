using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class CadastrarMateriaPrima : ContentPage
    {
        public CadastrarMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnConfirmarButtonClicked(object sender, EventArgs e)
        {
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
