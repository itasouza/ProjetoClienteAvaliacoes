using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Business.Models
{
    public class Cliente : Entity
    {
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string EstadoId { get; set; }
        public Estado Estado { get; set; }
        public string CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public ICollection<Avaliacao> Avaliacao { get; set; }


        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
