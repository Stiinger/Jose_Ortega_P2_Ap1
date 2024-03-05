using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Jose_Ortega_P2_Ap1.Api.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Accesorios> Accesorios { get; set; }
    public DbSet<VehiculosDetalle> VehiculosDetalle { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accesorios>().HasData(
            new Accesorios() { AccesorioId = 1, Descripcion = "Camara trasera" },
            new Accesorios() { AccesorioId = 2, Descripcion = "Pantalla interior" },
            new Accesorios() { AccesorioId = 3, Descripcion = "Interior en piel" },
            new Accesorios() { AccesorioId = 4, Descripcion = "Sun Roof" },
            new Accesorios() { AccesorioId = 5, Descripcion = "Aros de lujo" }
        );
        base.OnModelCreating(modelBuilder);
    }
}