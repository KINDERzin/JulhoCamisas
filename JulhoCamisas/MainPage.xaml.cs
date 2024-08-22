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
    	Application.Current.MainPage = new ListaAcabamentoPage();
    }

	void clicouBotaoEmpregado(object sender, EventArgs e)
    {
    	Application.Current.MainPage = new ListaCostureiraPage();
    }

	void clicouBotaoFornecedor(object sender, EventArgs e)
    {
    	Application.Current.MainPage = new ListaFornecedorPage();
    }
	
}

