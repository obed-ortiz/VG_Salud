using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_Pais
    {
        [Required(ErrorMessage = "Código requerido")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Pais requerido")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Abreviado de Pais requerido")]
        public string abrev { get; set; }
       
        public bool estado { get; set; }
    }
}
