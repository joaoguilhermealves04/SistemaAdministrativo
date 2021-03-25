using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string NumerodoLivro { get; set; }
        public List<LivroCadastro> LivroCadastros { get; set; }

        public Livro()
        {
            Id = Guid.NewGuid();
        }
    }
}
