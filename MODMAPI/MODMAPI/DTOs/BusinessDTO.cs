using System.ComponentModel.DataAnnotations;

namespace MODMAPI.DTOs
{
    public class BusinessDTO
    {
        public int BusinessId { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string BusinessType { get; set; }
        [Required]
        public DateTime ReleaseTime { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
