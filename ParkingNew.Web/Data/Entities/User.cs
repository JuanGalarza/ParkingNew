using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre_User { get; set; }
        public string Apellido_User { get; set; }
        public int Telefono { get; set; }
    }
}
