using E_commerce_Voetbal.Repositories.interfaces;
using E_Commerce_Voetbal.Domains_.Entities;
using E_Commerce_Voetbal.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace E_Commerce_Voetbal.Services
{
    public class MatchIService : IService<Match>
    {
        private readonly IDAO<Match> _matchDAO;

        public MatchIService(IDAO<Match> matchDAO)
        {
           _matchDAO = matchDAO;
        }

        public async Task<IEnumerable<Match>?> GetAllAsync()
        {
            return await _matchDAO.GetAllAsync();
        }
    }
}
