using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Business.Models
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public ICollection<Cidade> Cidade { get; set; }

        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
