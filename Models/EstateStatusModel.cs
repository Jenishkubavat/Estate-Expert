using System.ComponentModel.DataAnnotations;

namespace EstateAndLocation.Models
{
    public class EstateStatusModel
    {
        [Key]
        public int estateStatusId { get; set; } 
        public string? estateStatus { get; set; }
    }
}
