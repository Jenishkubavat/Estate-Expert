using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models;
[Table("city")]
public class CityModel
    {
    [System.ComponentModel.DataAnnotations.Key]
    public int cityID { get; set; }
        public string cityName { get; set; }
        public string cityCode { get; set; } 
        public int StateId { get; set; }

    [ForeignKey("StateId")]
    public virtual StateModel state { get; set; }
    public ICollection<UserDetailsModel> userCityDetails { get; set; }


    }

