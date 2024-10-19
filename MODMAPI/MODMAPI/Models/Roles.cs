using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string? RoleName { get; set; }
    }
}
