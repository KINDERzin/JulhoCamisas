using LiteDB;

namespace JulhoCamisas.Modelos;

public class Costureira : Registro{

  [BsonId]
  public Int64 Id { get; set; }
  
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Cpf { get; set; }
  public string Endereco { get; set; }
}