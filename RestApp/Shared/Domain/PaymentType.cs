using System.ComponentModel.DataAnnotations;

namespace RestApp.Shared.Domain
{
    public class PaymentType : BaseDomainModel
    {
        [Required]
        public string Type { get; set; }
    }
}
