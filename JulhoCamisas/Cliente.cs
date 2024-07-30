namespace  JulhoCamisas;

public class Cliente : Objeto{

    Int64 Id;
    String Nome;
    String Cpf;
    String Email;
    String Endereco;
    
//----------------------------------------------------

	public Cliente()
	{
        
	}

//----------------------------------------------------
    
    public void SetId(Int64 i)
    {
        Id = i;
    }

    public void SetNome(String n)
    {
        Nome = n;
    }
    public void SetCpf(String c)
    {
        Cpf = c;
    }

    public void SetEmail(String e)
    {
        Email = e;
    }

    public void SetEndereco(String e)
    {
        Endereco = e;
    }

//----------------------------------------------------

    public Int64 GetId()
    {
        return Id;
    }
    
    public String GetNome()
    {
        return Nome;
    }

    public String GetCpf()
    {
        return Cpf;
    }

    public String GetEmail()
    {
        return Email;
    }

    public String GetEndereco()
    {
        return Endereco;
    }
}
