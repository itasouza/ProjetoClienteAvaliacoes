﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAvaliacoes.ViewModels
{
    public class ClienteViewModel : EntityViewModel
    {

        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]

        public string NomeCliente { get; set; }

        [DisplayName("Email do Cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]

        public string EmailCliente { get; set; }

        [DisplayName("Nome do Estado")]
        public string EstadoId { get; set; }
        public EstadoViewModel Estado { get; set; }

        [DisplayName("Nome da Cidade")]
        public string CidadeId { get; set; }
        public CidadeViewModel Cidade { get; set; }

        public ICollection<AvaliacaoViewModel> Avaliacao { get; set; }


        [DisplayName("Ativo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }


        [DisplayName("Data Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Data Alteração")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }
    }
}