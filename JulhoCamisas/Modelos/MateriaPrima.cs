using LiteDB;

namespace JulhoCamisas.Modelos;

public  class MateriaPrima : Registro{

    [BsonId]
    
    public Int64 Id { get; set; } 

    public int Preco { get; set; }

    public string Fornecedor { get; set; }
    public string Materia_Prima { get; set; }
    

}