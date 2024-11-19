using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface INewsRepository
    {
        Task<IEnumerable<New>> GetAllNewsAsync();
        Task<New> CreateNewsAsync(New news);
        Task<bool> DeleteNewsAsync(int id);
        Task<New> GetNewsByIdAsync(int id);
    }
}
