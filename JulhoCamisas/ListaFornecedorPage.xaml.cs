using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas;
public partial class ListaFornecedorPage : ContentPage
{
  Controles.FornecedorControle clienteControle = new Controles.FornecedorControle();

  public ListaFornecedorPage()
	{
		InitializeComponent();

    ListaForncedor.ItemsSource = clienteControle.LerTodos();
	}

  void itemSelecionado(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastrarFornecedor();
    page.fornecedor = e.SelectedItem as Fornecedor;
    Application.Current.MainPage = page;
  }

  void NovoFornecedorClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarFornecedor();
  }

  void clicouBotaoVoltar(object sender, EventArgs e)
  {
    Application.Current.MainPage = new MainPage();
  }

}

