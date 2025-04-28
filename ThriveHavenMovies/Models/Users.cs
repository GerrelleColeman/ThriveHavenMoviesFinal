using Microsoft.AspNetCore.Identity;

namespace ThriveHavenMovies.Models
{
    public class Users : IdentityUser<Guid>  
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }



    }
}
