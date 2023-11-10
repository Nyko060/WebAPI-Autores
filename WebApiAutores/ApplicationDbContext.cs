using Microsoft.EntityFrameworkCore;
using WebApiAutores.Entidades;

namespace WebApiAutores
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) /**Constructor atraves del cual puede pasarce distintas configurtaciones para EF 
                                                                               * atraves de esas configuraciones se pueden pasar cosas como:
                                                                               * el conecction string EL CUAL va a apuntar a una base de datos que se va a utilizar (MS Sql en este caso)**/
        {

        }
        /**Tambien se pueden configurar los comando de las tablas que se van a generar a travces de los comandos de EF**/
        public DbSet<Autor> Autores {  get; set; } /**Aca se esta diciendo que se cree una tabla apartir del esquema o 
                                                    * de las propiedades de autor que esta en Entities 
                                                    * (se logra poniendo  ..DbSet<Autor>..  en un  ..ApplicationDbContext..  ) y (Autores sera el nombre de la tabla)**/
        public DbSet<Libro> Libro { get; set; }/**Se crea directamente aunque ya este este relacionado con Autores para que se pueda hacer query directamente**/

    }
}
