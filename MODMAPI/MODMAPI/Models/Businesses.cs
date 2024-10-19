using System.ComponentModel.DataAnnotations;

namespace MODMAPI.Models
{
    public class Businesses
    {
        [Key]
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public DateTime ReleaseTime { get; set; } = DateTime.Now;
    }
}
