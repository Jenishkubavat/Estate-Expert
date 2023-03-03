using System.ComponentModel.DataAnnotations;

namespace EstateAndLocation.Models
{
    public class EstateTypeModel
    {
        [Key]
        public int eTypeId { get; set; } 
        public string? TypeName { get; set; }
        
    }
}
