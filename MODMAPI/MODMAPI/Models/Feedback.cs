using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODMAPI.Models
{
    public class Feedback
    {
        #region Tablo
        [Key]
        public int FeedbackId { get; set; }
        public string? FeedbackType { get; set; }
        public string? Content { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        #endregion

        #region Iliskili Tablolar
        public User User { get; set; }
        #endregion
    }
}
