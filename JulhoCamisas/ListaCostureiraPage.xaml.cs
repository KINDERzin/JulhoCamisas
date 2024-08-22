
using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas;
public partial class ListaCostureiraPage : ContentPage
{
  Controles.CostureiraControle costureiraControle = new Controles.CostureiraControle();

  public ListaCostureiraPage()
	{
		InitializeComponent();

    ListaCostureira.ItemsSource = costureiraControle.LerTodos();
	}

  void itemSelecionado(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastrarCostureira();
    page.costureira= e.SelectedItem as Costureira;
    Application.Current.MainPage = page;
  }

  void NovaCostureiraClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarCostureira();
  }

  void clicouBotaoVoltar(object sender, EventArgs e)
  {
    Application.Current.MainPage = new MainPage();
  }

}

