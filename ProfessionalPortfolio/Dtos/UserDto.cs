using System;

namespace ProfessionalPortfolio.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string FullAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public string Hobbies { get; set; }
        public string Others { get; set; }
    }
}
