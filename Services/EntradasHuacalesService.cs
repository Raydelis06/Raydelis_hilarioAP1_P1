using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Raydelis_HilarioAP1_P1.DAL;
using Raydelis_HilarioAP1_P1.Models;
using System.Linq.Expressions;

namespace Raydelis_HilarioAP1_P1.Services
{
    public class EntradasHuacalesService(IDbContextFactory<Contexto>DbFactory)
    {
        //Metodo listar
        public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.EntradasHuacales.Where(criterio).AsNoTracking().ToListAsync();
        }
        //Metodo eliminar
        public async Task<bool>Eliminar(int IdEntrada)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            var estudiante = await contexto.EntradasHuacales.FindAsync(IdEntrada);
            return await contexto.EntradasHuacales.AsNoTracking().Where(e => e.IdEntrada == IdEntrada).ExecuteDeleteAsync() > 0;

        }
        //Metodo buscar
        public async Task<EntradasHuacales?>Buscar(int IdEntrada)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.EntradasHuacales.FirstOrDefaultAsync(h => h.IdEntrada == IdEntrada);
        }
        //Metodo modificar
        private async Task<bool> Modificar(EntradasHuacales entradaHuacal)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.EntradasHuacales.Update(entradaHuacal);
            return await contexto.SaveChangesAsync() > 0;
        }
        //Metodo insertar
        private async Task<bool> Insertar(EntradasHuacales entradaHuacal)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.EntradasHuacales.Add(entradaHuacal);
            return await contexto.SaveChangesAsync() > 0;
        }
        //Metodo existe
        private async Task<bool> Existe(int IdEntrada)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.EntradasHuacales.AnyAsync(h => h.IdEntrada == IdEntrada);
        }
        //Metodo guardar
        public async Task<bool> Guardar(EntradasHuacales entradaHuacal)
        {
            if(await Existe(entradaHuacal.IdEntrada))
            {

                return await Modificar(entradaHuacal);
            }
            else
            {
                return await Insertar(entradaHuacal);
            }
        }
    }
}
