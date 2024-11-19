using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Implementations;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            this._newsRepository = newsRepository;
        }

        public async Task<IEnumerable<NewsDTO>> GetAllNewsAsync()
        {
            var news = await _newsRepository.GetAllNewsAsync();
            if (news == null) return Enumerable.Empty<NewsDTO>();

            return news.Select(u => new NewsDTO
            {
                NewId = u.NewId,
                NewsTitle = u.NewsTitle,
                NewsDescription = u.NewsDescription,
                ReleaseTime = u.ReleaseTime,
                UserId = u.UserId
            });
        }

        public async Task<NewsDTO> CreateNewsAsync(NewsDTO newsDTO)
        {
            var news = new New{
                NewsTitle = newsDTO.NewsTitle,
                NewsDescription = newsDTO.NewsDescription,
                ReleaseTime = newsDTO.ReleaseTime,
                UserId = newsDTO.UserId
            };

            var createdNews = await _newsRepository.CreateNewsAsync(news);
            newsDTO.NewId = createdNews.NewId;
            return newsDTO;
        }

        public async Task<bool> DeleteNewsAsync(int id)
        {
            return await _newsRepository.DeleteNewsAsync(id);
        }

        public async Task<NewsDTO> GetNewsByIdAsync(int id)
        {
            var news = await _newsRepository.GetNewsByIdAsync(id);
            if (news == null) return null;

            return new NewsDTO
            {
                NewId = news.NewId,
                NewsTitle = news.NewsTitle,
                NewsDescription = news.NewsDescription,
                ReleaseTime = news.ReleaseTime,
                UserId = news.UserId
            };
        }
    }
}
