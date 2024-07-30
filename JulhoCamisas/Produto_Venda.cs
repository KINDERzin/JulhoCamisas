namespace JulhoCamisas;

public class Produto_Vendas : Objeto{

    Int64 IdVenda;
    Int64 IdProduto;

    public Produto_Vendas()
    {

    }

    public void SetIdVenda(Int64 i)
    {
        IdVenda = i;
    }

    public void SetIdProduto(Int64 i)
    {
        IdProduto = i;
    }

    public Int64 GetIdVenda()
    {
        return IdVenda;
    }

    public Int64 GetIdProduto()
    {
        return IdProduto;
    }
}