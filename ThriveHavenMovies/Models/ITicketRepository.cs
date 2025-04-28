namespace ThriveHavenMovies.Models
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> Tickets { get; }

        void Add(Ticket ticket);

        void Update(Ticket ticket);
        void Delete(Ticket ticket);
    }
}
