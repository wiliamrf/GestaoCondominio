using GC.Business.Models;

namespace GC.Api.ViewModels
{
    public class ApartamentoDTO
    {
        public Guid Id { get; set; }
        public int NumeroApto { get; set; }
        public string? Nome { get; set; }
        public int Telefone { get; set; }
        public string? Cpf { get; set; }
        public Carro? Carro { get; set; }
        public Moto? Moto { get; set; }
        public string? Observacao { get; set; }
        public IEnumerable<Correspondecia>? Correspondecias { get; set; }


    }
}

