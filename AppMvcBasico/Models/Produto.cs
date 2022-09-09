using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasico.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorID { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatorio.")]
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1}", MinimumLength =2)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        public string Imagem { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Ralation */

        public Fornecedor Fornecedor { get; set; }
    }
}
