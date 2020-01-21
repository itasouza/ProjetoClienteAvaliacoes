using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Business.Models
{
    public class Cidade : Entity
    {

        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }


        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
