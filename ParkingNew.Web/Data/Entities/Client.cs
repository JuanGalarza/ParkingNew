using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingNew.Web.Data.Entities
{
    public class Client
    {
        //Primary Key autoincrementable
        [Key]
        public int Id_Parking { get; set; }

        //ESTA PROPIEDAD QUIERE DECIR QUE ALGUNOS CAMPOS VAN A SER HEREDADOS POR USER
        public User User { get; set; }

        //es una expresion regular para habilitar donde se expresa que el capo recibe hasta 6 caracteres
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "El campo {0} debe iniciar con tres caracteres y terminar con tres números.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        //Placa del vehiculo del usuario
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Placa { get; set; }


        //aqui esta definida la propiedad para hacer la RELACION con la tabla userparking (RELACION MUCHOS A MUCHOS)
        public virtual ICollection<ClientParking> ClientParkings { get; set; }
    }
}
