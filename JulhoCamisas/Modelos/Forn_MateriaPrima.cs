using LiteDB;

namespace JulhoCamisas.Modelos;

public class Forn_MateriaPrima : Registro{

    [BsonId]
    public Int64 Id;

    public int Preco;

    public string Fornecedor;
    public string MateriaPrima;  
}