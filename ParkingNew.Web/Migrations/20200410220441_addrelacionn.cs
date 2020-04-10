using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingNew.Web.Migrations
{
    public partial class addrelacionn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "Id_User");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Parkings",
                newName: "Estado_Parking");

            migrationBuilder.RenameColumn(
                name: "Disponibles",
                table: "Parkings",
                newName: "Disponible_Parking");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Parkings",
                newName: "Id_Parking");

            migrationBuilder.AddColumn<double>(
                name: "Latitud_Parking",
                table: "Parkings",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitud_Parking",
                table: "Parkings",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "UserParkings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_User = table.Column<int>(nullable: false),
                    Id_Parking = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserParkings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserParkings_Parkings_Id_Parking",
                        column: x => x.Id_Parking,
                        principalTable: "Parkings",
                        principalColumn: "Id_Parking",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserParkings_Users_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Users",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserParkings_Id_Parking",
                table: "UserParkings",
                column: "Id_Parking");

            migrationBuilder.CreateIndex(
                name: "IX_UserParkings_Id_User",
                table: "UserParkings",
                column: "Id_User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserParkings");

            migrationBuilder.DropColumn(
                name: "Latitud_Parking",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "Longitud_Parking",
                table: "Parkings");

            migrationBuilder.RenameColumn(
                name: "Id_User",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Estado_Parking",
                table: "Parkings",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Disponible_Parking",
                table: "Parkings",
                newName: "Disponibles");

            migrationBuilder.RenameColumn(
                name: "Id_Parking",
                table: "Parkings",
                newName: "Id");
        }
    }
}
