using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_User { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellido_User { get; set; }
        public int Telefono { get; set; }
        //es una expresion regular para habilitar

        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "El campo {0} debe iniciar con tres caracteres y terminar con tres números.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Placa { get; set; }
    }
}
