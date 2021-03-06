using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProvaMed.Api.Extensions;

namespace ProvaMed.Api.ViewModels
{
    public class ContatoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "Maximo de caracteres permitidos para o campo {0} é {2} a {1}.", MinimumLength = 2)]
        public string Nome { get; set; }

        [MinimumAge(18, ErrorMessage = "Esta data {0} é invalida, o contato deve ter no minimo de dade é 18 anos.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [DocumentValidation(ErrorMessage = "Campo {0} é obrigatório")]
        public string Documento { get; set; }
        
    }
}
