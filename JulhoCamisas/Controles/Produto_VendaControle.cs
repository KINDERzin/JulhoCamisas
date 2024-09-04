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

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Produto_Venda>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Produto_Venda>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Produto_Venda>(NomeDaTabela);
    return new List<Produto_Venda>(tabela.FindAll().OrderBy(d => d.Id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Produto_Venda>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produto_Venda produto_Venda)
  {
    var collection = liteDB.GetCollection<Produto_Venda>(NomeDaTabela);
    collection.Upsert(produto_Venda);
  }

  //----------------------------------------------------------------------------
}