using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeCademyCapstone.Data;
using CodeCademyCapstone.Models;
using Microsoft.AspNetCore.Http;
using System.Web;



namespace CodeCademyCapstone.Controllers
{
    public class TeamsController : Controller
    {

        private readonly CodeCademyCapstoneContext _context;
        public TeamIndex teamIndex;
        public Team team;
        public Player player;
        
        public  TeamsController(CodeCademyCapstoneContext context)
        {
            _context = context;
            teamIndex = new TeamIndex(_context);
            player = new Player();
           
        }

        public async Task<IActionResult> Index()

        {
            return View(teamIndex);
        }

        [HttpPost]
        public IActionResult Index(string favoriteTeam)
        {
            teamIndex.FavoriteTeam = favoriteTeam;
            return View(teamIndex);
        }

        
        public async Task<IActionResult> Team(string id)
        {

            team = await _context.Teams
            .Include(t => t.Players)
            .Include(t => t.Division)
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.TeamId == id);

            return View(team);
        }

        public IActionResult Player(string id)
        {
            player = _context.Players.Find(id);

            return View("Views/Players/Player.cshtml", player);

        }

    }
}
