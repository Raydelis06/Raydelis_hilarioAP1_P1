using Microsoft.EntityFrameworkCore;
using Raydelis_HilarioAP1_P1.Models;

namespace Raydelis_HilarioAP1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<EntradasHuacales> EntradasHuacales { get; set; }
}
