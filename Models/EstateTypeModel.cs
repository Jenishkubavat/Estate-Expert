using System.ComponentModel.DataAnnotations;

namespace Estate_Expert.Models
{
    public class EstateTypeModel
    {
        [Key]
        public int EstateTypeId { get; set; } 
        public string? TypeName { get; set; }
        public ICollection<EstateDetailModel> estates { get; set; }
    }
}
