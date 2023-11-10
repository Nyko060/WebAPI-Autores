using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
/**Con esta migracion uno puede visualizar los cambios que van a hacer en la base de datos**/
namespace WebApiAutores.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable( /**Se crea una base de datos**/
                name: "Autores",            /**El nombre de la base sera: Autores**/
                columns: table => new
                {                                                           /**Las columnas seran Id que sera un entero int y Nombre que va a ser un nvarchar(max)**/
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");
        }
    }
}
