using LiteDB;

namespace JulhoCamisas.Modelos;

public class Fornecedor : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Cnpj { get; set; }
  public string Endereco { get; set; }
  public string Produto { get; set; }
}