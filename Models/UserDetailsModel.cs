using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estate_Expert.Models;

[Index(nameof(userName), IsUnique = true)]
public class UserDetailsModel
    {
    [Key]
    public int userId { get; set; }
    [Required(ErrorMessage = "User is required")]
    [Display(Name = "Username")]
    public string userName { get; set; }
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
    [Display(Name = "Email")]
    public string userEmail { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string userPassword { get; set; }
    [Required(ErrorMessage = "Confirm Password is required")]
    [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
    [Display(Name ="Conform Password")]
    [DataType(DataType.Password)]
    [Compare("userPassword")]
    public string  conformPassword { get; set; }
    public int userPhomeNumber { get; set; }
    public int userMobileNumber { get; set; }
    public string userAddress { get; set; }
    public int cityId { get; set; }
    public int stateId { get; set; }
    public string userDiscription { get; set; }

    public string userType { get; set; }
    public bool isAdmin { get; set; }
    public bool isActive { get; set; }
    public bool isDelete { get; set; }
}

