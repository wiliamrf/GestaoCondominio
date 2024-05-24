namespace GC.Business.Models
{
    public class Correspondecia : Entity
    {     
        public Guid ApartamentoId { get; set; }
        public string? Descricao { get; set; }
        public string? Rastreio { get; set; }

        public DateTime Recebimento { get; set; }
        public DateTime Entrega { get; set; }

        public Apartamento? Apartamento { get; set; }


    }
}
