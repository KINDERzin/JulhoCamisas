using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas;
public partial class ListaClientesPage : ContentPage
{
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
  Modelos.Cliente cliente = new Modelos.Cliente();

  public ListaClientesPage()
	{
		InitializeComponent();

    ListaClientes.ItemsSource = clienteControle.LerTodos();
	}

  void itemSelecionado(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastrarCliente();
    page.cliente = e.SelectedItem as Cliente;
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarCliente();
  }

  void clicouBotaoVoltar(object sender, EventArgs e)
  {
    Application.Current.MainPage = new MainPage();
  }

}

