using System.ComponentModel.DataAnnotations;

namespace DinhQuynhTrang606.Models
{
    public class DQT0606
    {
        [Key]
        [MaxLength(20)]
        public string DQTId { get; set; }

        [MaxLength(50)]
        public string DQTName { get; set; }
        public string DQTGender { get; set; }
    }
}
