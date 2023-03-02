using System.ComponentModel.DataAnnotations;

namespace EstateAndLocation.Models
{
    public class EstateStatusModel
    {
        [Key]
        public int EStatusId { get; set; } 
        public string EStateStatusName { get; set; }
    }
}
