using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasico.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter {2} ou {1} digitos.", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        [DisplayName("Endereço")]
        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
