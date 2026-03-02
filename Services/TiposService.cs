using Microsoft.EntityFrameworkCore;
using Raydelis_HilarioAP1_P1.DAL;
using Raydelis_HilarioAP1_P1.Models;
using System.Linq.Expressions;

namespace Raydelis_HilarioAP1_P1.Services
{
    public class TiposService(IDbContextFactory<Contexto> DbFactory)
    {
        //Metodo listar
        public async Task<List<TiposHuacales>> Listar(Expression<Func<TiposHuacales, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.TiposHuacales.Where(criterio).AsNoTracking().ToListAsync();
        }
        //Metodo guardar
        public async Task<bool> Guardar(TiposHuacales tipoHuacal)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.TiposHuacales.Update(tipoHuacal);
            return await contexto.SaveChangesAsync() > 0;
        }
    }
}
