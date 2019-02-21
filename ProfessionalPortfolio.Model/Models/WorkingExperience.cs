using ProfessionalPortfolio.Model.Models.Base;
using System;

namespace ProfessionalPortfolio.Model.Models
{
    public class WorkingExperience : EntityBase
    {
        public string CompanyName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool StillWorkingThere { get; set; }
    }
}
