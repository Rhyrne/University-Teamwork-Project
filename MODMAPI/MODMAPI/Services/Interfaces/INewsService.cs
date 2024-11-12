using MODMAPI.DTOs;
using MODMAPI.Models;

namespace MODMAPI.Services.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<NewsDTO>> GetAllNewsAsync();
        Task<NewsDTO> CreateNewsAsync(NewsDTO news);
        Task<bool> DeleteUserAsync(int id);
        Task<NewsDTO> GetNewsByIdAsync(int id);
    }
}
