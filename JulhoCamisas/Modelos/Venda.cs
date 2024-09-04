using LiteDB;

namespace JulhoCamisas.Modelos;

public class Vendas : Registro{

    [BsonId]
    public Int64 Id { get; set; }

    public int Total { get; set; }
    public int Desconto { get; set; }

    public string Cliente { get; set; }
    public string DataPedido { get; set; }
    public string DataEntrega { get; set; }
    public string ListaItensVendas { get; set; }
}