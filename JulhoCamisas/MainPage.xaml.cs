namespace JulhoCamisas;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	void clicouBotaoClientes(object sender, EventArgs e)
    {
    	Application.Current.MainPage = new ListaClientesPage();
    }

	void clicouBotaoAcabamento(object sender, EventArgs e)
    {
    	Application.Current.MainPage = new AcabamentoPage();
    }
	
}

