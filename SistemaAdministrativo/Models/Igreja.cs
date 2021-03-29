using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class Igreja
    {
        public Guid Id { get; set; }
        public string BairroIgreja { get; set; }
        public DateTime DatadaAbertura { get; set; }
        public List<Livro> Livros { get; set; }
        public Livro Livro { get; set; }
        public Guid IdLivro { get; set; }
        public List<IgrejaMinisterio> IgrejaMinisterios { get; set; }




        public Igreja()
        {
            Id = Guid.NewGuid();
        }
       
    }
}
