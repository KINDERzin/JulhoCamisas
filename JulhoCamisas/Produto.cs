namespace JulhoCamisas;

public class Produto : Objeto{

    String Item;
    int Valor;
    int Desconto;
    String Obs;
    Int64 IdProduto;
   
    public Produto()
    {

    }

    public void SetItem(String i)
    {
        Item = i;
    }

    public void SetValor(int v)
    {
        Valor = v;
    }

    public void SetDesconto(int d)
    {
        Desconto = d;
    }

    public void SetObs(String o)
    {
        Obs = o;
    }

    public void SetIdProduto(Int64 i)
    {
        IdProduto = i;
    }

    public String GetItem()
    {
        return Item;
    }

    public int GetValor()
    {
        return Valor;
    }

    public int GetDesconto()
    {
        return Desconto;
    }

    public String GetObs()
    {
        return Obs;
    }

    public Int64 GetIdProduto()
    {
        return IdProduto;
    }
}