using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas;
public partial class ListaAcabamentoPage : ContentPage
{
  Controles.AcabamentoControle acabamentoControle = new Controles.AcabamentoControle();

  public ListaAcabamentoPage()
	{
		InitializeComponent();

    ListaAcabamento.ItemsSource = acabamentoControle.LerTodos();
	}

  void itemSelecionado(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new CadastrarAcabamento();
    page.acabamento = e.SelectedItem as Acabamento;
    Application.Current.MainPage = page;
  }

  void NovoAcabamentoClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastrarAcabamento();
  }

  void clicouBotaoVoltar(object sender, EventArgs e)
  {
    Application.Current.MainPage = new MainPage();
  }

}

