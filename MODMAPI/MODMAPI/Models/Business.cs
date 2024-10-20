using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class Business
    {
        #region Tablo
        [Key]
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        #endregion

        #region Iliskili Tablolar
        public User User { get; set; }
        #endregion
    }
}
