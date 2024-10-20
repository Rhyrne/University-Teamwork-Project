using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class New
    {
        #region Tablo
        [Key]
        public int NewId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        #endregion

        #region Iliskili Tablolar
        public User User { get; set; }
        #endregion
    }
}
