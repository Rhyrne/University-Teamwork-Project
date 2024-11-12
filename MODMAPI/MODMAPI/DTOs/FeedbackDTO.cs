using System.ComponentModel.DataAnnotations;

namespace MODMAPI.DTOs
{
    public class FeedbackDTO
    {
        public int FeedbackId { get; set; }
        [Required]
        public string? FeedbackType { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public DateTime ReleaseTime { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
