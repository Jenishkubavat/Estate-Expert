using System.ComponentModel.DataAnnotations;

namespace Estate_Expert.Models
{
    public class LogInModel
    {
        [Required]
        public string UserName { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
