using System.ComponentModel.DataAnnotations;

namespace ParkingNew.Web.Data.Entities
{
    public class ClientParking
    {
        public int Id_Client { get; set; }
        public int Id_Parking { get; set; }


        //esta propiedad virtual es para hacer las conexiones entre los modelos usuarios y aparcamientos con esta
        public virtual Client Client { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
