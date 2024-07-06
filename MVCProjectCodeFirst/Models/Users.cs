using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProjectCodeFirst.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID {  get; set; }

        [Display(Name = "UserName: ")]
        [Required(ErrorMessage = "UserName is required!")]
        [MinLength(6, ErrorMessage = "Username must be at least 6 characters!")]
        public string username { get; set; }

        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        public string email { get; set; }

        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters!")]
        public string hashedPassword { get; set; }

        [Display(Name = "Confirmed Password: ")]
        [Required(ErrorMessage = "Confirm Password is required!")]
        [Compare("hashedPassword", ErrorMessage = "Passwords do not match!")]
        public string confirmedPassword {  get; set; }
        public string picturePath { get; set; }
    }
}