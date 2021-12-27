using System.ComponentModel.DataAnnotations;

namespace WebApp_10.Models
{
    public class ExpressionModel
    {
        [Key]
        public string Expression { get; set; }
        [Required]
        public int Value { get; set; }
    }
}