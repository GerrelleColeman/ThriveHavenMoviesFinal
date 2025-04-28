using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using ThriveHavenMovies.Models;

namespace ThriveHavenMovies.Data
{
    public class ShowingRepository : IShowingRepository
    {
        private readonly AppDbContext _context;

        public ShowingRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Showing> Showings => _context.Showings;





    }
}
