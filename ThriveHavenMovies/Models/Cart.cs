using System.ComponentModel.DataAnnotations.Schema;

namespace ThriveHavenMovies.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }

    }
}
