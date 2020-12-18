
using System.ComponentModel.DataAnnotations;


namespace CrudApp.Models
{
    public class Endereco
    {
        public int Id{ get; set; }


        [StringLength(50)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }


        [StringLength(15)]
        [Display(Name = "Numero")]
        public string Numero { get; set; }


        [StringLength(40)]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }


        [StringLength(40)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }


        [StringLength(2)]
        [Display(Name = "Estado")]
        public string UF { get; set; }


        [StringLength(9)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }


    }
}
