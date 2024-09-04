using LiteDB;

namespace JulhoCamisas.Modelos;

public class Produto : Registro{

    [BsonId]

    public Int64 Id { get; set; }

    public int Valor { get; set; }
    public int Desconto { get; set; }

    public string Item { get; set; }
    public string Obs { get; set; }
}