using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using SIGERP_API.Context;
using SIGERP_API.Models;

namespace SIGERP_API.Repositories
{
    public class CultivoRepository : ICultivoRepository
    {
        private readonly AppDbContext _context;
        
        public CultivoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cultivo> AddAsync(Cultivo newCultivo)
        {
            await _context.Cultivos.AddAsync(newCultivo);
            await _context.SaveChangesAsync();

            var cultivo = await GetByIdAsync(newCultivo.CultId);

            return cultivo;
        }

        public async Task DeleteAsync(int id)
        {
            var cultivo = await GetByIdAsync(id);

            _context.Cultivos.Remove(cultivo);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cultivo>> GetAllAsync()
        {
            //var lista = await _context.CultivoVariedads.ToListAsync();
            //var lista_cultivos = await _context.Cultivos.ToListAsync();

            //foreach (var cultivo in lista_cultivos)
            //{
            //    cultivo.CultivoVariedads.AddRange(lista.Where(f => f.CultId == cultivo.CultId));
            //}

            return await _context.Cultivos.ToListAsync();
        }

        public async Task<Cultivo> GetByIdAsync(int id)
        {
            return await _context.Cultivos.FindAsync(id);
        }

        public async Task UpdateAsync(int id, Cultivo cultivo)
        {
            var cultivoActual = await GetByIdAsync(id);

            cultivoActual.CultDescripcion = cultivo.CultDescripcion;

            _context.Cultivos.Update(cultivoActual);
            await _context.SaveChangesAsync();
        }
    }
}
