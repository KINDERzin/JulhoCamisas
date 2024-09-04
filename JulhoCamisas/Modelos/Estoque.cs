using LiteDB;

namespace JulhoCamisas.Modelos;

public class Estoque : Registro{

  [BsonId]
  public Int64 Id { get; set; }
  
  public int Quantidade { get; set; }

  public string Item { get; set; }
  public string Cor { get; set; }
  public string Fornecedor { get; set; }
}