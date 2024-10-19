using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class News
    {
        [Key]
        public int NewId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
