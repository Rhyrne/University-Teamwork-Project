using Microsoft.AspNetCore.Mvc;
using MODMAPI.DTOs;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNews()
        {
            var news = await _newsService.GetAllNewsAsync();
            return Ok(news);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNews(NewsDTO newsDTO)
        {
            var createdNews = await _newsService.CreateNewsAsync(newsDTO);
            return CreatedAtAction(nameof(GetNewsById), new { id = createdNews.NewId}, createdNews);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            var news = await _newsService.GetNewsByIdAsync(id);

            if (news == null) return NotFound();

            return Ok(news);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsById(int id)
        {
            var deletedNews = await _newsService.DeleteNewsAsync(id);

            if (!deletedNews) return NotFound();

            return NoContent();
        }
    }
}
