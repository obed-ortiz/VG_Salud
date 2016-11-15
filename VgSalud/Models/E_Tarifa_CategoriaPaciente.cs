using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
  public  class E_Tarifa_CategoriaPaciente
    {

        [Required(ErrorMessage = "Código requerido")]
        public int CodTarCate { get; set; }
       
        public string CodCatPac { get; set; }
        [Required(ErrorMessage = "Tarifa requerido")]
        public string CodTar { get; set; }
        [Required(ErrorMessage = "Precio requerido")]
        public decimal Precio { get; set; }

        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }






    }
}
