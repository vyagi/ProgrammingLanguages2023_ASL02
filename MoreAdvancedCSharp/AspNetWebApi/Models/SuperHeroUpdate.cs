using System.ComponentModel.DataAnnotations;

namespace AspNetWebApi.Models
{
    public class SuperHeroUpdate
    {
        [Range(18, 99, ErrorMessage = "You know, a hero needs to be adult, but too old")]
        public int Age { get; set; }

        [Required(ErrorMessage = "What hero would it be without powers")]
        [RegularExpression("[a-zA-Z]*(,[a-zA-Z]*)*", ErrorMessage = "List of powers comma separated is required")]
        public string Powers { get; set; }
    }
}
