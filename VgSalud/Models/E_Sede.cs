using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_Sede
    {
        [Required(ErrorMessage = "Código requerido")]
        public string CodSede { get; set; }
        [Required(ErrorMessage = "Sede requerido")]
        public string NomSede { get; set; }
        [Required(ErrorMessage = "Dirección requerido")]
        public string DireccSede { get; set; }
        [Required(ErrorMessage = "Teléfono requerido")]
        public string TelfSede { get; set; }
        public bool EstSede { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }

        public string AliasSede { get; set; }

    }
}
