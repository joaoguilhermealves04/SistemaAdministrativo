using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAdministrativo.Models
{
    public class Cadastro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Rg { get; set; }
        public string NumeroTelefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }
        public string ComunCongregcao { get; set; }
        public DateTime DataCadastro { get; set; }
        public Igreja Igreja { get; set; }
        public Guid IdIgreja { get; set; }
        public List<LivroCadastro> LivroCadastros { get; set; }
        public Cadastro()
        {

            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }

    }
}
