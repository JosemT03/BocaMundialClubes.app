using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BocaMundialClubesAPI.Migrations
{
    
    public partial class InicialVentas : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    TipoEntrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreComprador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoComprador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                });
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
