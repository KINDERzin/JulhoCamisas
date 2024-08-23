using JulhoCamisas.Modelos;

namespace Controles;

public class EstoqueControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EstoqueControle() : base()
  {
    NomeDaTabela = "Estoque";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idItem)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idItem);
  }

  //----------------------------------------------------------------------------

  public virtual List<Estoque>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return new List<Estoque>(tabela.FindAll().OrderBy(d => d.Id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idItem)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Delete(idItem);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Estoque estoque)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Upsert(estoque);
  }

  //----------------------------------------------------------------------------
}