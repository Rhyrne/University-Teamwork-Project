using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface INewsRepository
    {
        Task<IEnumerable<New>> GetAllNewsAsync();
        Task<New> CreateNewsAsync(New news);
        Task<bool> DeleteUserAsync(int id);
        Task<New> GetNewsByIdAsync(int id);
    }
}
