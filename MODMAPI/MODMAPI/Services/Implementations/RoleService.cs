using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }

        public async Task<IEnumerable<RoleDTO>> GetAllRolesAsync()
        {
            var roles = await _roleRepository.GetAllRolesAsync();
            if (roles == null) return Enumerable.Empty<RoleDTO>();

            return roles.Select(u => new RoleDTO { RoleId = u.RoleId, RoleName = u.RoleName }).ToList();
        }
    }
}