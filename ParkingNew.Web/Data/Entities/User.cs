using Microsoft.AspNetCore.Identity;
using ParkingNew.Common;
using System.ComponentModel.DataAnnotations;

namespace ParkingNew.Web.Data.Entities
{
    public class User : IdentityUser
    {
        //Primary Key autoincrementable
        [Key]
        [Required]
        public int Id_User { get; set; }

        //Nombre del usuario
        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Documento_User { get; set; }

        //Nombre del usuario
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_User { get; set; }

        //Apellido del usuario
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellido_User { get; set; }

        //Direccion del usuario
        [Display(Name = "Direccion")]
        public string Direccion_User { get; set; }

        //Foto de perfil
        [Display(Name = "Foto")]
        public string Foto_User { get; set; }

        //El tipo de usuario
        [Display(Name = "Tipo De Usuario")]
        public UserType UserType { get; set; }

        //este es una propiedad de lectura para concatenar el nombre completo
        public string NombreCompleto => $"{Nombre_User} {Apellido_User}";

    }



}
