namespace GC.Business.Models
{
    public class Moto : Entity
    {
       
        public int ApartamentoId { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public Cores Cor { get; set; }
        public Apartamento? Apartamento { get; set; }
    }
}
