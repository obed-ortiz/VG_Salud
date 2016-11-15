using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VgSalud.Models
{
    public class E_Login
    {
        public string CodigoUsuario { get; set; } //codigo
        public string Nombres { get; set; } //alias
        public string AliasUsu { get; set; }//password
        public string NomSede { get; set; }//nombre
        public string NomServi { get; set; }//apellido
        public string Pass { get; set; }//DNI
        public string CodSede { get; set; }//FechaNac
       /* public string estado { get; set; }//estado
        public string profesion { get; set; }//profesion
        public string codSede { get; set; }//codSede*/
    }
}
