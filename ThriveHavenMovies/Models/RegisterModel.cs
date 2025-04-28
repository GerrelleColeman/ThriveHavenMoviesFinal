using System.ComponentModel.DataAnnotations;

namespace ThriveHavenMovies.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        public string Email { get; set; }
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}