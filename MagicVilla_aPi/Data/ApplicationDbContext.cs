using MagicVilla_aPi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_aPi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }


        public DbSet<Villa> Villas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Villa Real",
                    Detalle = "Detalle de la villa....",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Premium vista a la Piscina",
                    Detalle = "Detalle de la villa....",
                    ImagenUrl = "",
                    Ocupantes = 3,
                    MetrosCuadrados = 30,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                }

            );
        }
    }
}
