using Microsoft.AspNetCore.Mvc;
using MODMAPI.DTOs;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var User = await _userService.GetUserByIdAsync(id);
            if(User == null) return NotFound();

            return Ok(User);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDTO userDTO)
        {
            var createdUser = await _userService.CreateUserAsync(userDTO);
            return CreatedAtAction(nameof(GetUserById), new {id = createdUser.UserId}, createdUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserDTO userDTO)
        {
            var updatedUser = await _userService.UpdateUserAsync(id, userDTO);
            if(updatedUser == null) return NotFound();

            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var deletedUser = await _userService.DeleteUserAsync(id);
            if(!deletedUser)return NotFound();

            return NoContent();
        }
    }
}
