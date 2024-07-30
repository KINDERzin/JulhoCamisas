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
            // Lógica para confirmar o cadastro da matéria-prima
            string tipo = TipoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string fornecedor = FornecedorEntry.Text;

            // Adicione a lógica de processamento dos dados aqui
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar
            Navigation.PopAsync();
        }
    }
}
