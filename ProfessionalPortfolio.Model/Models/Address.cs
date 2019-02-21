using ProfessionalPortfolio.Model.Models.Base;

namespace ProfessionalPortfolio.Model.Models
{
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
