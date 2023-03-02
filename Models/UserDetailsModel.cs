using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estate_Expert.Models;
[Table("userDetails")]
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
    public string? userEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string? userPassword { get; set; }
    [Required(ErrorMessage = "Confirm Password is required")]
    [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
    [NotMapped]
    [Display(Name ="Conform Password")]
    [DataType(DataType.Password)]
    [Compare("userPassword")]
    public string  conformPassword { get; set; }
    [Display(Name = "Phone Number:")]
    [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
    public int? userPhomeNumber { get; set; }
    [Required(ErrorMessage ="Mobile number is required")]
    [Display(Name = "Mobile Number:")]
    [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
    public int userMobileNumber { get; set; }

    public string? userAddress { get; set; }
    
    public int? cityId { get; set; }
    public int? stateId { get; set; }
    [DataType(DataType.MultilineText)]
    public string? userDiscription { get; set; }
    [Required(ErrorMessage ="Select wether you are agent or a buyer")]
    public string userType { get; set; }
    [Required]
    public bool isAdmin { get; set; }=false;
    [Required]
    public bool isActive { get; set; }=true;
    [Required]
    public bool isDelete { get; set; }= false;
    [ForeignKey("cityId")]
    public virtual CityModel userCity { get; set; }
    [ForeignKey("stateId")]
    public virtual StateModel userState { get; set; }
    public ICollection<SignInLogModel> signInLogs { get; set; }
}

