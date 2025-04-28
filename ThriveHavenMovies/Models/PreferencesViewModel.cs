namespace ThriveHavenMovies.Models
{
    public class PreferencesViewModel
    {
        public Users CurrentUser { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
