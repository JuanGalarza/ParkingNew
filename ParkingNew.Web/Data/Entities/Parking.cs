using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class Parking
    {
        //Primary Key autoincrementable
        [Required]
        public int Id { get; set; }

        //nombre del parqueadero
        [Required (ErrorMessage ="El campo {0} es obligatorio.")]
        [Display(Name = "Nombre Parqueadero")]
        public string Nombre_Parking { get; set; }

        //Precio hora fraccion es para que los precios tengan identificador de moneda $, separacion de miles y 2 decimales y en falso apr ano editar mas adelante
        //[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Precio por hora")]
        public decimal Precio_Parking { get; set; }

        //Direccion parqueadero
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Direccion parqueadero")]
        public string Direccion_Parking { get; set; }

        //Imagen del parqueadero
        [Display(Name = "Imagen")]
        public string Imagen_Parking { get; set; }

        //Disponibilidad
        [Display(Name = "Disponible")]
        public bool Estado { get; set; }

        //NumeroAparcamiento disponibles
        [Display(Name = "Aparcamientos Disponibles")]
        public int Disponibles { get; set; }
    }
}
