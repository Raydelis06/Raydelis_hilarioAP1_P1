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
            return await contexto.EntradasHuacales
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }
        //Metodo eliminar
        public async Task<bool>Eliminar(int viajeId)
        {
            return true;
        }
        //Metodo buscar
        public async Task<EntradasHuacales?>Buscar(int viajeId)
        {
            return null;
        }
        //Metodo modificar
        private async Task<bool> Modificar(EntradasHuacales viajeEspacial)
        {
            return true;
        }
        //Metodo insertar
        private async Task<bool> Insertar(EntradasHuacales viajeEspacial)
        {
            return true;
        }
        //Metodo existe
        private async Task<bool> Existe(int viajeId)
        {
            return true;
        }
        //Metodo guardar
        public async Task<bool> Guardar(EntradasHuacales viajeEspacial)
        {
            return true;
        }
    }
}
