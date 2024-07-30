using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace JulhoCamisas
{
    public partial class Estoque : ContentPage
    {
        public ObservableCollection<StockItem> StockItems { get; set; }

        public Estoque()
        {
            InitializeComponent();
            StockItems = new ObservableCollection<StockItem>
            {
                new StockItem { ImageSource = "item_image.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Quantity = "Quantidade: ---" },
                new StockItem { ImageSource = "item_image.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Quantity = "Quantidade: ---" },
                new StockItem { ImageSource = "item_image.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Quantity = "Quantidade: ---" },
                new StockItem { ImageSource = "item_image.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Quantity = "Quantidade: ---" }
            };
            BindingContext = this;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

    public class StockItem
    {
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
    }
}
