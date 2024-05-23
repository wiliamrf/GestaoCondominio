using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GC.Business.Models
{
    public class Apartamento:Entity
    {
       
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
