using Microsoft.EntityFrameworkCore;
using Raydelis_HilarioAP1_P1.Models;

namespace Raydelis_HilarioAP1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<EntradasHuacales> EntradasHuacales { get; set; }
    public DbSet<TiposHuacales> TiposHuacales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TiposHuacales>().HasData(new List<TiposHuacales>()
        {
            new TiposHuacales(){TipoId = 1, Descripcion = "Rojo"},
            new TiposHuacales(){TipoId = 2, Descripcion = "Verde"}
        });
    }
}
