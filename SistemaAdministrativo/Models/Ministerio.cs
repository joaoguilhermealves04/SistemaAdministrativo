using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class Ministerio
    {
        public Guid Id{ get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime DataOrdenacao { get; set; }

        public List<IgrejaMinisterio> IgrejaMinisterios { get; set; }

        public Ministerio()
        {
            Id= Guid.NewGuid();
        }
    }
}
