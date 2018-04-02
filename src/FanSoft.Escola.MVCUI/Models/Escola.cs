using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FanSoft.Escola.MVCUI.Models
{
    public class Escola:Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Nome { get; set; }
        public DateTime DataFundacao { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Endereco { get; set; }
    }
}
