using BiblioSol.Domain.Entities.Books;
using BiblioSol.Domain.Entities.Facilities;
using BiblioSol.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Persistence.Context
{
    public class DBBibliotecaContext :DbContext
    {
        public DBBibliotecaContext(DbContextOptions<DBBibliotecaContext> options) : base(options)
        {
            // Constructor logic if needed
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configuration can be done here
        }
        // Define DbSet properties for your entities here
        // For example, if you have an entity called "Book", you would add:
        // public DbSet<Book> Books { get; set; }
        public  DbSet<Categoria> Categoria { get; set; }

        public  DbSet<EstadoPrestamo> EstadoPrestamos { get; set; }

        public  DbSet<Libros> Libros { get; set; }

        public  DbSet<Penalizacion> Penalizacions { get; set; }

        public  DbSet<Prestamo> Prestamos { get; set; }

        public  DbSet<Rol> Rols { get; set; }

        public  DbSet<Usuarios> Usuarios { get; set; }
    }
}
