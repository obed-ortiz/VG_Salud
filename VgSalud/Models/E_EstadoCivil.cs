using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_EstadoCivil
    {
        [Required(ErrorMessage = "Código requerido")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Descripción requerido")]
        public string nombre { get; set; }
        public bool estado { get; set; }
    }
}
