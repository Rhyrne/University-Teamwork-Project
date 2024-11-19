using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface IBusinessRepository
    {
        Task<IEnumerable<Business>> GetAllBusinessAsync();
        Task<Business> CreateBusinessAsync(Business business);
        Task<bool> DeleteBusinessAsync(int id);
        Task<Business> GetBusinessByIdAsync(int id);
    }
}
