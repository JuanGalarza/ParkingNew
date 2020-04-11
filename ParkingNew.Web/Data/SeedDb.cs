using ParkingNew.Web.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        //metodo que va a llenar la base de datos si no existe
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckParkingsAsync();
        }

        private async Task CheckParkingsAsync()
        {
            if (!_context.Parkings.Any())
            {
                _context.Parkings.Add(new Parking
                {
                    Nombre_Parking = "Parqueadero La Quinta",
                    Precio_Parking = 1000,
                    Direccion_Parking = "Cra. 5 #11-98",
                    Longitud_Parking = 1234,
                    Latitud_Parking = 1234,

                });

                _context.Parkings.Add(new Parking
                {
                    Nombre_Parking = "Aparcamiento La Cuarta",
                    Precio_Parking = 1500,
                    Direccion_Parking = "Carrera 4 #13-62",
                    Longitud_Parking = 1369,
                    Latitud_Parking = 1369,

                });

                _context.Parkings.Add(new Parking
                {
                    Nombre_Parking = "Parqueadero Murillo Toro",
                    Precio_Parking = 2000,
                    Direccion_Parking = "Cra 4  # 10",
                    Longitud_Parking = 2468,
                    Latitud_Parking = 2468,

                });
                await _context.SaveChangesAsync();
            }

            

            

        }
    }
}
