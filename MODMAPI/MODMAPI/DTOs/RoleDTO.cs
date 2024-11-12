using System.ComponentModel.DataAnnotations;

namespace MODMAPI.DTOs
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
