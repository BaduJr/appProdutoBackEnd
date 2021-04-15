using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appProdutoBackEnd.Models
{

    [Table("tblproduto")]
    public class Produto
    {
        public Int64 id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public String nome { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public Decimal preco { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int quantidade { get; set; }
    }
}
