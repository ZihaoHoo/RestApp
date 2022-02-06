using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class Cuisine : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
