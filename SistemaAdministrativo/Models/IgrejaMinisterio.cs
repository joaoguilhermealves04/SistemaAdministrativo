using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class IgrejaMinisterio
    {
        public Ministerio Ministerio { get; set; }
        public Guid MinisterioId { get; set; }
        public Igreja Igreja{ get; set; }
        public Guid igrejaId { get; set; }
    }
}
