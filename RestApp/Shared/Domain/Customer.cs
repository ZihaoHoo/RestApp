using System.Collections.Generic;

namespace RestApp.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Request { get; set; }

    }
}
