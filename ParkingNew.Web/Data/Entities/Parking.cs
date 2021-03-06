﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingNew.Web.Data.Entities
{
    public class Parking
    {
        //Primary Key autoincrementable
        [Key]
        public int Id_Parking { get; set; }

        //nombre del parqueadero
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
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
        public bool Estado_Parking { get; set; }

        //NumeroAparcamiento disponibles
        [Display(Name = "Aparcamientos Disponibles")]
        public int Disponible_Parking { get; set; }

        //Digitar la longitud y latitud
        public double Longitud_Parking { get; set; }
        public double Latitud_Parking { get; set; }


        //aqui esta definida la propiedad para hacer la RELACION con la tabla userparking (RELACION MUCHOS A MUCHOS)
        public virtual ICollection<ClientParking> ClientParkings { get; set; }
    }
}
