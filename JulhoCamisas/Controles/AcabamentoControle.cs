using JulhoCamisas.Modelos;

namespace Controles;

public class AcabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public AcabamentoControle() : base()
  {
    NomeDaTabela = "Acabamento";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idAcabamento)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual List<Acabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    return new List<Acabamento>(tabela.FindAll().OrderBy(d => d.Tipo));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idAcabamento)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Delete(idAcabamento);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Acabamento acabamento)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    collection.Upsert(acabamento);
  }

  //----------------------------------------------------------------------------
}