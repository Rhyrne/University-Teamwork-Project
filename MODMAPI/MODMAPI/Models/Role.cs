using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class Role
    {
        #region Tablo
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        #endregion

        #region Iliskili Tablolar
        public ICollection<User> Users { get; set; }
        #endregion
    }
}
