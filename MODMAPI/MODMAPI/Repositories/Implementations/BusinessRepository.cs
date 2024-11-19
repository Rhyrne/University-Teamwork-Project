using Microsoft.EntityFrameworkCore;
using MODMAPI.Data;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;

namespace MODMAPI.Repositories.Implementations
{
    public class BusinessRepository : IBusinessRepository
    {
        private readonly AppDbContext _context;

        public BusinessRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Business> CreateBusinessAsync(Business business)
        {
            _context.Businesses.Add(business);
            await _context.SaveChangesAsync();
            return business;
        }

        public async Task<bool> DeleteBusinessAsync(int id)
        {
            var business = await _context.Businesses.FindAsync(id);
            if (business == null) return false;

            _context.Businesses.Remove(business);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Business>> GetAllBusinessAsync()
        {
            return await _context.Businesses.ToListAsync();
        }

        public async Task<Business> GetBusinessByIdAsync(int id)
        {
            return await _context.Businesses.FirstOrDefaultAsync(b => b.BusinessId == id);
        }
    }
}
