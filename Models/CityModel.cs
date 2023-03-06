using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models
{
    public class CityModel
    {
        [Key]
        public int SityID { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public virtual StateModel state { get; set; }
        public ICollection<UserDetailsModel> userCityDetails { get; set; }
    }
}
