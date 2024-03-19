using AutoMapper;
using E_commerce_Voetbal.ViewModels;
using E_Commerce_Voetbal.Domains_.Entities;
using E_Commerce_Voetbal.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_Voetbal.Controllers
{
    public class MatchController : Controller
    {

        private readonly IService<Match> _matchService;
        private readonly IMapper _mapper;
        public MatchController(IMapper mapper, IService<Match> matchService)
        {
            _mapper = mapper;
            _matchService = matchService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var matches = await _matchService.GetAllAsync();
                List<MatchVM> matchVMs = _mapper.Map<List<MatchVM>>(matches);
                return View(matchVMs);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return View();
        }
    }
}
