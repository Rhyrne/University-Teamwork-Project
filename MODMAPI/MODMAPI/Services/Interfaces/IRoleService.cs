using MODMAPI.DTOs;

namespace MODMAPI.Services.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDTO>> GetAllRolesAsync();
    }
}
