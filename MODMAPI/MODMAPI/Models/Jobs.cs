using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class Jobs
    {
        [Key]
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
