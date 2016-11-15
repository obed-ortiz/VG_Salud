using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace VgSalud.Models
{
  public  class E_Pacientes
    {
        [Required(ErrorMessage = "Número de Historia requerido")]
        public int       Historia    { get;set;}
        [Required(ErrorMessage = "Apellido Paterno requerido")]
        public string    ApePat     { get; set; }
        
        public string    ApeMat     { get; set; }
        [Required(ErrorMessage = "Nombres requerido")]
        public string    NomPac     { get; set; }
        [Required(ErrorMessage = "Fecha Nacimiento requerido")]
        public DateTime  FecNac     { get; set; }
        [Required(ErrorMessage = "Sector requerido")]
        public string    Sector     { get; set; }
       
        public string    NumDoc     { get; set; }
       
        public string    Ruc        { get; set; }
       
        public string    Essalud    { get; set; }
       
        public string    CodAseg    { get; set; }
       
        public DateTime  FecAfil    { get; set; }
       
        public string    PaisNac    { get; set; }
      
        public string    DepNac     { get; set; }
       
        public string    ProvNac    { get; set; }
        
        public string    DistNac    { get; set; }
      
        public string    Direcc     { get; set; }
       
        public string    Email      { get; set; }
       
        public string    TelfFijo   { get; set; }
        
        public string    TelfCel    { get; set; }
       
        public int       CodTipPac  { get; set; }
     
        public string    Observ         { get; set; }
       
        public int       Discap         { get; set; }
       
        public string    TipSang    { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string    Alerg      { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string    TitParent  { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string    TitNom     { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string    TitDni     { get; set; }
        [Required(ErrorMessage = "Código requerido")]
        public string    TitObs     { get; set; }
        public string    Ocup       { get; set; }
        public string    DirTrab    { get; set; }
        public string    TelTrab    { get; set; }
        public string    CodCatPac  { get; set; }
        public string    CodEstCivil { get; set; }
        public string    CodSexo    { get; set; }
        public string    CodTipFil  { get; set; }
        public string    CodDocIdent { get; set; }
        public string    CodDist    { get; set; }
        public string    CodProv    { get; set; }
        public string    CodDep     { get; set; }
        public string    CodPais    { get; set; }
        public string    EstPac     { get; set; }
        public string    Crea       { get; set; }
        public string    Modifica   { get; set; }
        public string    Elimina    { get; set; }








    }
}
