using Microsoft.EntityFrameworkCore;
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

        public Task<Cultivo> AddAsync(Cultivo newCultivo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Cultivo cultivo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cultivo>> GetAllAsync()
        {
            return await _context.Cultivos.ToListAsync();
        }

        public Task<Cultivo> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cultivo cultivo)
        {
            throw new NotImplementedException();
        }
    }
}
