namespace JulhoCamisas;

public class Fornecedor : Objeto{

    Int64 Id;
    int Preco;
    String Nome;
    String Email;
    String Endereco;
    String Produto;

//----------------------------------------------------

	public Fornecedor()
	{
        
	}

//----------------------------------------------------
    
    public void SetId(Int64 i)
    {
        Id = i;
    }

    public void SetPreco(int p)
    {
        Preco = p;
    }

    public void SetNome(String n)
    {
        Nome = n;
    }
    
    public void SetEmail(String e)
    {
        Email = e;
    }

    public void SetEndereco(String e)
    {
        Endereco = e;
    }

    public void SetProduto(String p)
    {
        Produto = p;
    }

//----------------------------------------------------

    public Int64 GetId()
    {
        return Id;
    }

    public int GetPreco()
    {
        return Preco;
    }
    
    public String GetNome()
    {
        return Nome;
    }

    public String GetEmail()
    {
        return Email;
    }

    public String GetEndereco()
    {
        return Endereco;
    }
    public String GetProduto()
    {
        return Produto;
    }

}