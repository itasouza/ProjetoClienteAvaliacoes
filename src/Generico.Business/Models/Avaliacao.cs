using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Business.Models
{
    public class Avaliacao : Entity
    {

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int? QuantidadeEstrela { get; set; }
        public string AvaliacaoUtil { get; set; }

        public int ProdutoId { get; set; }
        public  Produto Produto { get; set; }

        public int ClienteId { get; set; }
        public  Cliente Cliente { get; set; }


        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }


    }
}
