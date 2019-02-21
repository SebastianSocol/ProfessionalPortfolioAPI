using ProfessionalPortfolio.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessionalPortfolio.Model.Models
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        [NotMapped]
        public int age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public string Hobbies { get; set; }
        public string Other { get; set; }

        public virtual Address Address { get; set; }
        public virtual IEnumerable<Skill> Skills { get; set; }
        public virtual IEnumerable<Education> Educations { get; set; }
        public virtual IEnumerable<WorkingExperience> WorkingExperiences { get; set; }
    }
}
