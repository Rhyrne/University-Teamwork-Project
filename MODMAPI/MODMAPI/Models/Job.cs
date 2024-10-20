using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class Job
    {
        #region Tablo
        [Key]
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        #endregion

        #region Iliskili Tablolar
        public User User { get; set; }
        #endregion
    }
}
