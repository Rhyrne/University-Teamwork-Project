using Microsoft.AspNetCore.Mvc;
using MODMAPI.DTOs;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        public readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFeedbacks()
        {
            var feedbacks = await _feedbackService.GetAllFeedbacksAsync();
            return Ok(feedbacks);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeedback(FeedbackDTO feedbackDTO)
        {
            var createdFeedback = await _feedbackService.CreateFeedbackAsync(feedbackDTO);
            return CreatedAtAction(nameof(GetFeedbackById), new { id = createdFeedback.FeedbackId }, createdFeedback);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedbackById(int id)
        {
            var feedback = await _feedbackService.GetFeedbackByIdAsync(id);

            if (feedback == null) return NotFound();

            return Ok(feedback);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedbackById(int id)
        {
            var deletedFeedback = await _feedbackService.DeleteFeedbackAsync(id);

            if (!deletedFeedback) return NotFound();

            return Ok(deletedFeedback);
        }
    }
}
