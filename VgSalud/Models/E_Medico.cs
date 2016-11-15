using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_Medico
    {
        [Required(ErrorMessage = "Código requerido")]
        public string CodMed { get; set; }
        [Required(ErrorMessage = "Nombres requerido")]
        public string NomMed { get; set; }
        [Required(ErrorMessage = "Dni requerido")]
        public string DniMed { get; set; }
        [Required(ErrorMessage = "Tipo Medico requerido")]
        public int TipPrfMed { get; set; }
        [Required(ErrorMessage = "Cole requerido")]
        public string ColgMed { get; set; }
        [Required(ErrorMessage = "Rne requerido")]
        public string RneMed { get; set; }
        [Required(ErrorMessage = "Direccion requerido")]
        public string DireccMed { get; set; }
        [Required(ErrorMessage = "Fecha requerido")]
        public DateTime FecIngMed { get; set; }
        [Required(ErrorMessage = "Teléfono requerido")]
        public string TelfMed { get; set; }
        public string ObservMed { get; set; }
        [Required(ErrorMessage = "Servicio requerido")]
        public string CodServ { get; set; }
        [Required(ErrorMessage = "Especialidad requerido")]
        public string CodEspec { get; set; }
        [Required(ErrorMessage = "Empresa requerido")]
        public string CodEmp { get; set; }
        public bool EstMed { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }




    }
}
