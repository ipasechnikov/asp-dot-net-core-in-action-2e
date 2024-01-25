using System.ComponentModel.DataAnnotations;

namespace F_CarsWebApi.Models
{
    public class Car
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }
    }
}
