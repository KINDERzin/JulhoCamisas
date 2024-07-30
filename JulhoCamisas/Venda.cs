namespace JulhoCamisas;

public class Vendas : Objeto{

    String Cliente; 
    String DataPedido;
    Int64 Id;
    String DataEntrega;
    String ListaItensVendas;
    int Total;
    int Desconto;

    public Vendas()
    {

    }

    public void SetCliente(String e)
    {
        Cliente = e;
    }

    public void SetDataPedido(String d)
    {
        DataPedido = d;
    }

    public void SetTotal(int t)
    {
        Total = t;
    }

    public void SetDesconto(int d)
    {
        Desconto = d;
    }

    public void SetDataEntrega(String d)
    {
        DataEntrega = d;
    }

    public void SetListaItensVenda(String l)
    {
        ListaItensVendas = l;
    }

    public void SetId(Int64 i)
    {
        Id = i;
    }

    public String GetCliente()
    {
        return Cliente;
    }

    public String GetDataPedido()
    {
        return DataPedido;
    }

    public int GetTotal()
    {
        return Total;
    }

    public int GetDesconto()
    {
        return Desconto;
    }

    public String GetDataEntrega()
    {
        return DataEntrega;
    }

    public String GetListaItensVendas()
    {
        return ListaItensVendas;
    }

    public Int64 GetId()
    {
        return Id;
    }
}