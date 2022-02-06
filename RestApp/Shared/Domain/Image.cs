using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class Image : BaseDomainModel
    {
        [Required]
        public string Rest_Name { get; set; }
        [Required]
        public string Img_url { get; set; }
    }
}
