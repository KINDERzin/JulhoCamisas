using Microsoft.Maui.Controls;

namespace JulhoCamisas
{
    public partial class Loja : ContentPage
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void Comprar_Clicked(object sender, EventArgs e)
        {
            // Lógica para processar a compra
            // Exemplo:
            DisplayAlert("Compra", "Item adicionado ao carrinho!", "OK");
        }
    }
}