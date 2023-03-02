using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estate_Expert.Models
{
    [Table("signInLogs")]
    public class SignInLogModel
    {
        [Key]
        public int logId{ get; set; }
        [Required]
        public int userId { get; set; }
        [Required]
        public DateTime Time { get; set; }= DateTime.Now;
        [ForeignKey("userId")]
        public virtual UserDetailsModel logDetails { get; set; }
    }
}
