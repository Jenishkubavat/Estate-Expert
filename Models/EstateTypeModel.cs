using System.ComponentModel.DataAnnotations;

namespace EstateAndLocation.Models
{
    public class EstateTypeModel
    {
        [Key]
        public int ETypeId { get; set; } 
        public string TypeName { get; set; }
    }
}
