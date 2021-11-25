using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class UserProfile
    {
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
    }

    public enum Sex
    {
        Female,
        Male
    };
}