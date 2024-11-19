using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<UserDTO> CreateUserAsync(UserDTO userDTO)
        {
            var user = new User
            {
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                CCNumber = userDTO.CCNumber,
                Email = userDTO.Email,
                Password = userDTO.Password,
                RoleId = userDTO.RoleId
            };

            var createdUser = await _userRepository.CreateUserAsync(user);
            userDTO.UserId = createdUser.UserId;
            return userDTO;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteUserAsync(id);
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            if (users == null) return Enumerable.Empty<UserDTO>();

            return users.Select(u => new UserDTO
            {
                UserId = u.UserId,
                Name = u.Name,
                Surname = u.Surname,
                CCNumber = u.CCNumber,
                Email = u.Email,
                RoleId = u.RoleId
            }).ToList();
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return null;

            return new UserDTO
            {
                UserId = user.UserId,
                Name = user.Name,
                Surname = user.Surname,
                CCNumber = user.CCNumber,
                Email = user.Email,
                Password = user.Password,
                RoleId = user.RoleId
            };

        }

        public async Task<UserDTO> UpdateUserAsync(int id, UserDTO userDTO)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return null;

            user.Name = userDTO.Name;
            user.Surname = userDTO.Surname;
            user.Email = userDTO.Email;
            user.RoleId = userDTO.RoleId;

            await _userRepository.UpdateUserAsync(user);
            return userDTO;
        }
    }
}
