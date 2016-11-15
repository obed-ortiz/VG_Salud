using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
 public   class E_Empresa_Tercero
    {
        [Required(ErrorMessage = "Código requerido")]
        public string CodEmp { get; set; }
        [Required(ErrorMessage = "Razón social requerido")]
        public string RazonEmp { get; set; }
        [Required(ErrorMessage = "RUC requerido")]
        public string RucEmp { get; set; }
        [Required(ErrorMessage = "Dirección requerido")]
        public string DireccEmp { get; set; }
        public bool EstEmp { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }



    }
}
