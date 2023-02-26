using SIGERP_API.Models;

namespace SIGERP_API.Repositories
{
    public interface ICultivoRepository
    {
        Task<List<Cultivo>> GetAllAsync();
        Task<Cultivo> GetByIdAsync(int id);
        Task<Cultivo> AddAsync(Cultivo newCultivo);
        Task UpdateAsync(Cultivo cultivo);
        Task DeleteAsync(Cultivo cultivo);
    }
}
