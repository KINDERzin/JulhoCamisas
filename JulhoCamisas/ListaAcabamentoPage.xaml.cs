using JulhoCamisas.Modelos;
using Microsoft.Maui.Controls;

namespace JulhoCamisas;
public partial class ListaAcabamentoPage : ContentPage
{
  Controles.AcabamentoControle acabamentoControle = new Controles.AcabamentoControle();
  Modelos.Acabamento acabamento = new Modelos.Acabamento();

  public ListaAcabamentoPage()
	{
		InitializeComponent();

    ListaAcabamento.ItemsSource = acabamentoControle.LerTodos();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ListaAcabamento.ItemsSource = acabamentoControle.LerTodos();
    }

    void itemSelecionado(object sender, SelectedItemChangedEventArgs e)
  {
    var page = new AcabamentoPage();
    page.acabamentoPage = e.SelectedItem as AcabamentoPage;
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

