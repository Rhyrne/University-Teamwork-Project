using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface IFeedbackRepository
    {
        Task<IEnumerable<Feedback>> GetAllFeedbacksAsync();
        Task<Feedback> CreateFeedbackAsync(Feedback feedback);
        Task<bool> DeleteFeedbackAsync(int id);
        Task<Feedback> GetFeedbackByIdAsync(int id);
    }
}
