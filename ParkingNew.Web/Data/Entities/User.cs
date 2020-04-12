using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class User
    {
        //Primary Key autoincrementable
        [Key]
        [Required]
        public int Id_User { get; set; }

        //Nombre del usuario
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_User { get; set; }

        //Apellido del usuario
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellido_User { get; set; }

        //Telefono del usuario
        public int Telefono { get; set; }
        
        //es una expresion regular para habilitar donde se expresa que el capo recibe hasta 6 caracteres
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "El campo {0} debe iniciar con tres caracteres y terminar con tres números.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        //Placa del vehiculo del usuario
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Placa { get; set; }

        //aqui esta definida la propiedad para hacer la relacion con la tabla userparking (RELACION MUCHOS A MUCHOS)
        public virtual ICollection<ClientParking> UserParkings { get; set; }
    }
}
