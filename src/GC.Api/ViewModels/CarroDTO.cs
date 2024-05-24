using GC.Business.Models;

namespace GC.Api.ViewModels
{
    public class CarroDTO
    {
        public Guid Id { get; set; }
        public Guid ApartamentoId { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public Cores Cor { get; set; }

        public Apartamento? Apartamento { get; set; }
    }
}
