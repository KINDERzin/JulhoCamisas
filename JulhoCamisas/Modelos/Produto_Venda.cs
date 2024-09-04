using LiteDB;

namespace JulhoCamisas.Modelos;

public class Produto_Vendas : Registro{

    [BsonId]
    public Int64 Id { get; set; } 
    public Int64 IdVenda { get; set; }
    public Int64 IdProduto { get; set; } 
}