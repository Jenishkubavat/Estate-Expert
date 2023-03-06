using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models
{
    public class InChargeModel
    {
        [Key]
        public int InChargreId { get; set; }
        [Required]
        public int EstateId { get; set; }
        [Required]
        public int AgentId { get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set;}
        [DataType(DataType.Date)]

        public DateTime? DateTo { get; set;}
        [ForeignKey("EstateId")]
        public virtual EstateDetailModel EstateDetail { get; set; }
        [ForeignKey("AgentId")]
        public virtual UserDetailsModel AgentDetails { get; set; }

    }
}
