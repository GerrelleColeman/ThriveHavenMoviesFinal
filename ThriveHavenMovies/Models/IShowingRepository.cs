using ThriveHavenMovies.Data;

namespace ThriveHavenMovies.Models
{
    public interface IShowingRepository
    {

        IEnumerable<Showing> Showings { get; }

        

    }
}
