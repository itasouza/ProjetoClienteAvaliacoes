using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Business.Models
{
    public class Produto : Entity
    {
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal? ValorProduto { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string FotoProduto { get; set; }
        public bool ProdutoPromocao { get; set; }
        public  ICollection<Avaliacao> Avaliacao { get; set; }

        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
