using Estate_Expert.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAndLocation.Models
{
    public class EstateDetailModel
    {
        [Key]
        public int estateId { get; set; }   
        public string? estateName { get; set; }    
        public int cityId { get;set; }
        public int estateTypeId { get; set; }
        public decimal ? floorSpace { get; set; }
        public int ? numberOfBalconies { get; set; }  
        public decimal ? balconiesSpace { get; set; }  
        public int ? numberOfBedrooms { get; set; }   
        public int ? numberOfBathrooms { get; set; }  
        public int ? numberOfGarages { get; set; }    
        public int ? numberOfParkingSpaces { get; set; }   
        public bool ? petAllowed { get; set; }
        [DataType(DataType.MultilineText)]
        public string? estateDescription { get; set; }   
        public int estateStatusId { get; set; }

        //ForeignKeys
        [ForeignKey("cityId")]
        public virtual  CityModel estateCity { get; set; }
        [ForeignKey("estateTypeId")]
        public virtual EstateTypeModel estateType { get; set; }
        [ForeignKey("estateStatusId")]
        public virtual EstateStatusModel Status { get; set; }



    }
}
