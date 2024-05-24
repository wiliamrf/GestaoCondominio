using GC.Business.Models;

namespace GC.Api.ViewModels
{
    public class CorrespondeciaDTO
    {
        public Guid Id { get; set; }
        public Guid ApartamentoId { get; set; }
        public string? Descricao { get; set; }
        public string? Rastreio { get; set; }
        public DateTime Recebimento { get; set; }
        public DateTime Entrega { get; set; }
        public Apartamento? Apartamento { get; set; }

    }
}
