using JulhoCamisas;

namespace Julhocamisas;

public class Funcionario : Objeto{

    String Nome;
    String Email;
    String Endereco;
    Int64 Id;

    public Funcionario()
    {

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

    public void SetId(Int64 i)
    {
        Id = i;
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

    public Int64 GetId()
    {
        return Id;
    }

}