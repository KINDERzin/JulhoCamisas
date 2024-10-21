using JulhoCamisas.Modelos;

namespace Controles;

public class Produto_VendaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public Produto_VendaControle() : base()
  {
    NomeDaTabela = "Produto e Venda";
  }

  //----------------------------------------------------------------------------

  public virtual void Criar()
    {

    }
//----------------------------------------------------------------------------

    public virtual void Atualizar()
    {

    }
//----------------------------------------------------------------------------

    public virtual Registro? LerTodos()
    {
        return  null;
    }
//----------------------------------------------------------------------------
    public virtual void Apagar()
    {

    }

  //----------------------------------------------------------------------------
}