using System.ComponentModel.DataAnnotations;

namespace EstateAndLocation.Models
{
    public class EstateDetailModel
    {
        [Key]
        public int EstateId { get; set; }   
        public string EstateName { get; set; }    
        public int CityId { get;set; }
        public int EstateTypeId { get; set; }
        public decimal ? FloorSpace { get; set; }
        public int ? NumberOfBalconies { get; set; }  
        public decimal ? BalconiesSpace { get; set; }  
        public int ? NumberOfBedrooms { get; set; }   
        public int ? NumberOfBathrooms { get; set; }  
        public int ? NumberOfGarages { get; set; }    
        public decimal ? NumberOfParkingSpaces { get; set; }   
        public bool ? PestAllowed { get; set; }   
        public string EstateDescription { get; set; }   
        public int EstateStatusId { get; set; } 
    }
}
