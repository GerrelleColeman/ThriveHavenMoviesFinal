namespace ThriveHavenMovies.Models
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Movies { get; }

        Movie getMovieName(string name);
    }


}
