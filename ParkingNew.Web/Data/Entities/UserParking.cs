using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class UserParking
    {
        public int Id { get; set; }

        public int Id_User { get; set; }
        public int Id_Parking { get; set; }
    }
}
