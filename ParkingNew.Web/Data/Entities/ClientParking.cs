using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class ClientParking
    {
        [Key]
        public int Id { get; set; }

        public int Id_User { get; set; }
        public int Id_Parking { get; set; }


        //esta propiedad virtual es para hacer las conexiones entre los modelos usuarios y aparcamientos con esta
        public virtual User User { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
