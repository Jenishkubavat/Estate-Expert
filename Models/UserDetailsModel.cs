using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estate_Expert.Models;
[Table("userDetails")]
[Index(nameof(UserName), IsUnique = true)]
public class UserDetailsModel
    {
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "User is required")]
    [Display(Name = "Username")]

    public string? UserName { get; set; }
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
    [Display(Name = "Email")]
    public string? UserEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string? UserPassword { get; set; }
    [Required(ErrorMessage = "Confirm Password is required")]
    [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
    [NotMapped]
    [Display(Name ="Conform Password")]
    [DataType(DataType.Password)]
    [Compare("UserPassword")]
    public string?  ConformPassword { get; set; }
    [Display(Name = "Phone Number:")]
    [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
    public int? UserPhomeNumber { get; set; }
    [Required(ErrorMessage ="Mobile number is required")]
    [Display(Name = "Mobile Number:")]
    [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
    public int UserMobileNumber { get; set; }

    public string? UserAddress { get; set; }

    public int? CityId { get; set; } 
    public int? StateId { get; set; } 
    [DataType(DataType.MultilineText)]
    public string? UserDiscription { get; set; }
    [Required(ErrorMessage ="Select wether you are agent or a buyer")]
    public string UserType { get; set; }= string.Empty;
    
    public bool isAdmin { get; set; }=false;
    
    public bool isActive { get; set; }=true;
   
    public bool isDelete { get; set; }= false;
    [ForeignKey("CityId")]
    public virtual CityModel? userCity { get; set; } = null;
    [ForeignKey("StateId")]
    public virtual StateModel? userState { get; set; } = null;
    public ICollection<SignInLogModel>? signInLogs { get; set; } = null;

    public ICollection<InChargeModel>? inchargeagent { get; set; } = null;
}

