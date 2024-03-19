using E_commerce_Voetbal.Repositories.interfaces;
using E_Commerce_Voetbal.Domains_.Data;
using E_Commerce_Voetbal.Domains_.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Voetbal.Repositories
{
    public class MatchIDAO : IDAO<Match>
    {
        private readonly ProLeagueDbContext _context;

        public MatchIDAO(ProLeagueDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Match>?> GetAllAsync()
        {
            try
            {
                return await _context.Matches.Include(a => a.HomeTeam)
                    .Include(a => a.VisitorTeam)
                    .Include(a => a.HomeTeam.Stadium)
                    .Where(a => a.Season.StartDate <= DateTime.Now && a.Season.EndDate >= DateTime.Now && a.Date >= DateTime.Now)
                    .ToListAsync();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
