using System;
using System.ComponentModel.DataAnnotations;

namespace BankMS.Model
{
    public class UserModel
    {
        public string Id { get; set; }

        [Required, RegularExpression(@"^[A-Z]{1}[a-z]*$", ErrorMessage = "Please enter a valid name eg 'Gideon'")]
        public string FirstName { get; set; }

        [Required, RegularExpression(@"^[A-Z]{1}[a-z]*$",
            ErrorMessage = "Name must Start with capital letters and must be all alphabets for example 'Gideon'.")]
        public string LastName { get; set; }

        public string Name
        {
            get { return $"{LastName}, {FirstName}"; }
        }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$",
            ErrorMessage = "Password mus contains Caps, small letters, \nnumbers and special chracters")]
        public string Password { get; set; }

        public UserModel()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 10); ;
        }

    }
}
