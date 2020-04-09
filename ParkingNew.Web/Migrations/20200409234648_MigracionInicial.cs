using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingNew.Web.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre_Parking = table.Column<string>(nullable: false),
                    Precio_Parking = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Direccion_Parking = table.Column<string>(nullable: false),
                    Imagen_Parking = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Disponibles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parkings");
        }
    }
}
