using JulhoCamisas.Modelos;

namespace Controles;

public class CostureiraControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CostureiraControle() : base()
  {
    NomeDaTabela = "Costureira";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCostureira)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costureira>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costureira>(NomeDaTabela);
    return new List<Costureira>(tabela.FindAll().OrderBy(d => d.Id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCostureira)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Delete(idCostureira);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costureira costureira)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Upsert(costureira);
  }

  //----------------------------------------------------------------------------
}