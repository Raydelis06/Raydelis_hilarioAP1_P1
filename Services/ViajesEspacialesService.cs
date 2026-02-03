using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Raydelis_HilarioAP1_P1.DAL;
using Raydelis_HilarioAP1_P1.Models;
using System.Linq.Expressions;

namespace Raydelis_HilarioAP1_P1.Services
{
    public class ViajesEspacialesService(IDbContextFactory<Contexto>DbFactory)
    {
        //Metodo listar
        public async Task<List<ViajesEspaciales>> Listar(Expression<Func<ViajesEspaciales, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.ViajesEspaciales
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }
        //Metodo eliminar
        public async Task<bool>Eliminar(int viajeId)
        {

        }
        //Metodo buscar
        public async Task<ViajesEspaciales?>Buscar(int viajeId)
        {

        }
        //Metodo modificar
        private async Task<bool> Modificar(ViajesEspaciales viajeEspacial)
        {

        }
        //Metodo insertar
        private async Task<bool> Insertar(ViajesEspaciales viajeEspacial)
        {

        }
        //Metodo existe
        private async Task<bool> Existe(int viajeId)
        {

        }
        //Metodo guardar
        public async Task<bool> Guardar(ViajesEspaciales viajeEspacial)
        {

        }
    }
}
