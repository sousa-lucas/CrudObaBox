using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CrudApp.Models
{
    public class Cliente
    {
        public int Id{ get; set; }


        [StringLength(40)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [StringLength(14)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }


        [StringLength(20)]
        [Display(Name = "RG")]
        public string RG { get; set; }


        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; }


        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
        
        [Display(Name = "Inativo")]
        public bool Inativo { get; set; }

    }
}
