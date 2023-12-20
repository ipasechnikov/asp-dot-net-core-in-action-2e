using System.ComponentModel.DataAnnotations;

namespace D_UsingApiControllerAttribute.Models
{
    public class UpdateModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
