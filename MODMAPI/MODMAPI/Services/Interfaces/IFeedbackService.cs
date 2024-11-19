using MODMAPI.DTOs;

namespace MODMAPI.Services.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<FeedbackDTO>> GetAllFeedbacksAsync();
        Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO feedbackDTO);
        Task<bool> DeleteFeedbackAsync(int id);
        Task<FeedbackDTO> GetFeedbackByIdAsync(int id);
    }
}
