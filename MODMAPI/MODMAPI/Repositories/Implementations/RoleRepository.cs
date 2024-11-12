using Microsoft.EntityFrameworkCore;
using MODMAPI.Data;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;

namespace MODMAPI.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }
    }
}
