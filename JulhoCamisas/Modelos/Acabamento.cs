using LiteDB;

namespace JulhoCamisas.Modelos;

public class Acabamento : Registro{
  
  [BsonId]
  public int Id { get; set; }

  public string Quantidade { get; set; }
  public string Tipo { get; set; }
  public string Cor { get; set; }
  public string Fornecedor { get; set; }
}