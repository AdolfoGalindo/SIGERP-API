using SIGERP_API.Models;

namespace SIGERP_API.Repositories
{
    public interface ICultivoRepository
    {
        Task<List<Cultivo>> GetAllAsync();
        Task<Cultivo> GetByIdAsync(int id);
        Task<Cultivo> AddAsync(Cultivo newCultivo);
        Task UpdateAsync(int id, Cultivo cultivo);
        Task DeleteAsync(int id);

    }
}
