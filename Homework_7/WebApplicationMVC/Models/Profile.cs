using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class UserProfile
    {
        [Required(ErrorMessage = "The field must be filled")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The field must be filled")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Sex")]
        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        Female,
        Male
    }
}