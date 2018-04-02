using System;
using System.ComponentModel.DataAnnotations;

namespace FanSoft.Escola.MVCUI.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

    }
}
