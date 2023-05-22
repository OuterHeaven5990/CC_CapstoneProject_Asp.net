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
    public class PlayersController : Controller
    {


        private readonly CodeCademyCapstoneContext _context;
        public PlayerIndex playerIndex;
        public Player player;


        public PlayersController(CodeCademyCapstoneContext context)
        {
            _context = context;
            playerIndex = new PlayerIndex();
            player = new Player();


        }

        public IActionResult Index()
        {
            playerIndex.onGet(_context);
            return View(playerIndex);
        }

        [HttpPost]
        public IActionResult Index(string selectedTeam, string selectedPosition, string searchString, string sortField )
        {
            playerIndex.SelectedTeam = selectedTeam;
            playerIndex.SelectedPosition = selectedPosition;
            playerIndex.SearchString = searchString;
            playerIndex.SortField = sortField;
            playerIndex.onGet(_context);
            return View(playerIndex);
        }

        public IActionResult Player(string id)
        {
            player = _context.Players.Find(id);

            return View(player);

        }
    }
}
