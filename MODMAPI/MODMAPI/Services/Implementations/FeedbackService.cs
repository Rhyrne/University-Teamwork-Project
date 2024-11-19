using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            this._feedbackRepository = feedbackRepository;
        }

        public async Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO feedbackDTO)
        {
            var feedback = new Feedback
            {
                FeedbackType = feedbackDTO.FeedbackType,
                Content = feedbackDTO.Content,
                ReleaseTime = feedbackDTO.ReleaseTime,
                UserId = feedbackDTO.UserId
            };

            var createdFeedback = await _feedbackRepository.CreateFeedbackAsync(feedback);
            feedbackDTO.FeedbackId = createdFeedback.FeedbackId;
            return feedbackDTO;
        }

        public async Task<bool> DeleteFeedbackAsync(int id)
        {
            return await _feedbackRepository.DeleteFeedbackAsync(id);
        }

        public async Task<IEnumerable<FeedbackDTO>> GetAllFeedbacksAsync()
        {
            var feedback = await _feedbackRepository.GetAllFeedbacksAsync();
            if (feedback == null) return Enumerable.Empty<FeedbackDTO>();

            return feedback.Select(f => new FeedbackDTO {
                FeedbackId = f.FeedbackId,
                FeedbackType = f.FeedbackType,
                Content = f.Content,
                ReleaseTime = f.ReleaseTime,
                UserId = f.UserId
            });
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _feedbackRepository.GetFeedbackByIdAsync(id);
            if (feedback == null) return null;

            return new FeedbackDTO
            {
                FeedbackId = feedback.FeedbackId,
                FeedbackType = feedback.FeedbackType,
                Content = feedback.Content,
                ReleaseTime = feedback.ReleaseTime,
                UserId = feedback.UserId
            };
        }
    }
}
