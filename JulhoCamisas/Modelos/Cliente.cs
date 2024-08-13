using LiteDB;

namespace JulhoCamisas.Modelos;

public class Cliente : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Sobrenome { get; set; }
  public string Telefone { get; set; }
}