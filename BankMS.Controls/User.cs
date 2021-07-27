using System;
using System.ComponentModel.DataAnnotations;

namespace BankMS.Model
{
    public class User
    {
        public string Id { get; set; }

        [Required, RegularExpression(@"^[A-Z]{1}[a-z]*$", ErrorMessage ="Please enter a valid name eg 'Gideon'")]
        public string FirstName { get; set; }

        [Required, RegularExpressionAttribute(@"^[A-Z]{1}[a-z]*$",
            ErrorMessage = "Name must Start with capital letters and must be all alphabets for example 'Gideon'.")]
        public string LastName { get; set; }

        public string Name
        {
            get { return $"{LastName}, {FirstName}"; }
        }
        [Required, EmailAddressAttribute]
        public string Email { get; set; }

        [Required, RegularExpressionAttribute(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$",
            ErrorMessage = "PAssword mus contains\nCapital letters small letters, numbers and special chracters")]
        public string Password { get; set; }

        public User()
        {
            Id = new Guid().ToString();
        }

    }
}
