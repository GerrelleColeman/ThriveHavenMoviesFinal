namespace ThriveHavenMovies.Models
{
    public interface IConcessionRepository
    {
        IEnumerable<Concession> Concessions { get; }
    }
}
