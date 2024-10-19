using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CCNumber { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
    }
}
