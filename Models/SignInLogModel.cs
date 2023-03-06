using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models
{
    [Table("signInLogs")]
    public class SignInLogModel
    {
        [Key]
        public int LogId{ get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime Time { get; set; }= DateTime.Now;
        [ForeignKey("UserId")]
        public virtual UserDetailsModel logDetails { get; set; }
    }
}
