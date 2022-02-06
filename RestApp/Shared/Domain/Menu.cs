using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class Menu : BaseDomainModel
    {
        [Required]
        public string Rest_Name { get; set; }
        [Required]
        public string Path_url { get; set; }
    }
}
