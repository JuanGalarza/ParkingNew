using System.ComponentModel.DataAnnotations;

namespace ParkingNew.Web.Data.Entities
{
    public class Admin
    {
        //Primary Key autoincrementable
        [Key]
        public int Id_Admin { get; set; }

        //ESTA PROPIEDAD QUIERE DECIR QUE ALGUNOS CAMPOS VAN A SER HEREDADOS POR USER
        public User User { get; set; }
    }
}
