using System.ComponentModel.DataAnnotations;

namespace MODMAPI.DTOs
{
    public class NewsDTO
    {
        public int NewId { get; set; }
        [Required]
        public string NewsTitle { get; set; }
        [Required]
        public string NewsDescription { get; set; }
        [Required]
        public DateTime ReleaseTime { get; set; } 
        [Required]
        public int UserId { get; set; }
    }
}
