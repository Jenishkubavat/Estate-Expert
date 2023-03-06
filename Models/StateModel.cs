using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models;
[Table("state")]
public class StateModel
    {
    [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    public ICollection<CityModel> cities { get; set; }
    public ICollection<UserDetailsModel> userStateDetails { get; set; }
    }
