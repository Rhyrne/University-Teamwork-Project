using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class Feedbacks
    {
        [Key]
        public int FeedbackId { get; set; }
        public string? FeedbackType { get; set; }
        public string? Content { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
