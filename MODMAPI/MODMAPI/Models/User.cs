using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class User
    {
        #region Tablo
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CCNumber { get; set; }
        public string Email { get; set; }
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        #endregion

        #region Iliskili Tablolar
        public Role Role { get; set; }
        public ICollection<New> New {  get; set; }
        public ICollection<Job> Job { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
        public ICollection<Business> Business { get; set; }
        #endregion
    }
}
