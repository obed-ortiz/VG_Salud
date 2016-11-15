using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_Tipo_Tarifa
    {
        [Required(ErrorMessage = "Código Requerido")]
        public string CodTipTar { get; set; }
        [Required(ErrorMessage = "Descripción Requerido")]
        public string DescTipTar { get; set; }
        [Required(ErrorMessage = "Especialidad Requerido")]
        public string CodEspec { get; set; }
        public bool EstTipTar { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }
   
    }
}
