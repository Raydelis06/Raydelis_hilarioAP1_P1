using Microsoft.EntityFrameworkCore;

namespace Raydelis_HilarioAP1_P1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
