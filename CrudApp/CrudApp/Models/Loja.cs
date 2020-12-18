using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CrudApp.Models
{
    public class Loja
    {
        public int Id{ get; set; }


        [StringLength(40)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}
