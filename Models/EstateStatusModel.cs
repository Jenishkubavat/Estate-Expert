using System.ComponentModel.DataAnnotations;

namespace Estate_Expert.Models
{
    public class EstateStatusModel
    {
        [Key]
        public int EstateStatusId { get; set; } 
        public string? EstateStatus { get; set; }
        public ICollection<EstateDetailModel> estatesDetails { get; set; }
    }
}
