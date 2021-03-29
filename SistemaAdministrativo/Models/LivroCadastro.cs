using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class LivroCadastro
    {
        public Guid LivroId { get; set; }
        public Livro Livro { get; set; }
        public Guid CadastroId{ get; set; }
        public  Cadastro  Cadastro { get; set; }

      
    }
}
