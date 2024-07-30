namespace JulhoCamisas;

public  class MateriaPrima : Objeto{

    String Fornecedor;
    String Materia_Prima;
    int Preco;
    Int64 Id;

    public MateriaPrima()
    {

    }

    public void SetFornecedor(String f)
    {
        Fornecedor = f;
    }

    public void SetMateriaPrima(String m)
    {
        Materia_Prima = m;
    }

    public void SetPreco(int p)
    {
        Preco = p;
    }

    public void SetIdProduto(Int64 i)
    {
        Id = i;
    }

    public Int64 GetIdVenda()
    {
        return Id;
    }

    public String GetFornecedor()
    {
        return Fornecedor;
    }
    public String GetMateriaPrima()
    {
        return Materia_Prima;
    }
    public int GetPreco()
    {
        return Preco;
    }
}