using Microsoft.EntityFrameworkCore;
using MODMAPI.Data;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;

namespace MODMAPI.Repositories.Implementations
{
    public class NewsRepository : INewsRepository
    {
        private readonly AppDbContext _context;

        public NewsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<New> CreateNewsAsync(New news)
        {
            _context.News.Add(news);
            await _context.SaveChangesAsync();
            return news;
        }

        public async Task<bool> DeleteNewsAsync(int id)
        {
            var news = await _context.News.FindAsync(id);
            if (news == null) return false;

            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<New>> GetAllNewsAsync()
        {
            return await _context.News.ToListAsync();
        }

        public async Task<New> GetNewsByIdAsync(int id)
        {
            return await _context.News.FirstOrDefaultAsync(n => n.NewId == id);
        }
    }
}
