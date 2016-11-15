using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
 public   class E_Servicios
    {
        [Required(ErrorMessage = "Código requerido")]
        public string CodServ { get; set; }
        [Required(ErrorMessage = "Servicio requerido")]
        public string NomServ { get; set; }
        [Required(ErrorMessage = "Especialidad requerido")]
        public string CodEspec { get; set; }
        [Required(ErrorMessage = "Empresa requerido")]
        public string CodEmp { get; set; }
       
        public bool EstServ { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }

    }
}
