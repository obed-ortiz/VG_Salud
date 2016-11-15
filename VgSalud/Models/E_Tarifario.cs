using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
  public  class E_Tarifario
    {
        [Required(ErrorMessage = "Código requerido")]
        public string CodTar { get; set; }
        [Required(ErrorMessage = "Descripción requerido")]
        public string DescTar { get; set; }
        [Required(ErrorMessage = "Precio requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Precio Unitario requerido")]
        public string PrecioUnit { get; set; }
       
        public string AfecIgcv { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string ModPrecTar { get; set; }
        [Required(ErrorMessage = "Especialidad requerido")]
        public string CodEspec { get; set; }
        [Required(ErrorMessage = "Tipo Tarifa requerido")]
        public string CodTipTar { get; set; }
        [Required(ErrorMessage = "STipo Tarifa requerido")]
        public string CodSTipTar { get; set; }
        [Required(ErrorMessage = "Moneda requerido")]
        public string CodTipMon { get; set; }
        public bool EstTar { get; set; }
        public string Crea { get; set; }
        public string Modifica { get; set; }
        public string Elimina { get; set; }



    }
}
