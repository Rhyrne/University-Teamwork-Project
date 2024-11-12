using System.ComponentModel.DataAnnotations;

namespace MODMAPI.DTOs
{
    public class JobDTO
    {
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public DateTime ReleaseTime { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
