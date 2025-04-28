using System.ComponentModel.DataAnnotations.Schema;

namespace ThriveHavenMovies.Models
{
    public class Order
    {
        public int Id { get; set; } 

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }
    }
}
