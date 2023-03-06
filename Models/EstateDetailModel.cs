
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models
{
    public class EstateDetailModel
    {
        [Key]
        public int EstateId { get; set; }   
        public string? EstateName { get; set; }    
        public int cityId { get;set; }
        public int EstateTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ? FloorSpace { get; set; }
        public int ? NumberOfBalconies { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ? BalconiesSpace { get; set; }  
        public int ? NumberOfBedrooms { get; set; }   
        public int ? NumberOfBathrooms { get; set; }  
        public int ? NumberOfGarages { get; set; }    
        public int ? NumberOfParkingSpaces { get; set; }   
        public bool ? PetAllowed { get; set; }
        [DataType(DataType.MultilineText)]
        public string? EstateDescription { get; set; }   
        public int EstateStatusId { get; set; }

        //ForeignKeys
        [ForeignKey("cityId")]
        public virtual  CityModel estateCity { get; set; }
        [ForeignKey("EstateTypeId")]
        public virtual EstateTypeModel estateType { get; set; }
        [ForeignKey("EstateStatusId")]
        public virtual EstateStatusModel Status { get; set; }

        public ICollection<InChargeModel> inchargeestate { get; set; }



    }
}
