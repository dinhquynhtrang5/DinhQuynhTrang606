using System.ComponentModel.DataAnnotations;

namespace DinhQuynhTrang606.Models
{
    public class CompanyDQT606
    {
        [Key]

        [MaxLength(20)]
        public string CompanyId { get; set; }
        [MaxLength(50)]
        public string CompanyName { get; set; }
    }
}
