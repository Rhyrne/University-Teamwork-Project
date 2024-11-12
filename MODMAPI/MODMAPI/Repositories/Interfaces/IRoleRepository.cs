using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetAllRolesAsync();
    }
}
