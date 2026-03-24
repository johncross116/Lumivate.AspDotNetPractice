using Lumivate.TurtleStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    public class TurtlesController : Controller
    {
        private readonly ITurtleService _turtleService;

        public TurtlesController(ITurtleService turtleService)
        {
            _turtleService = turtleService;
        }

        // GET: /Turtles
        public IActionResult Index()
        {
            var turtles = _turtleService.GetAllTurtles();
            return View(turtles);
        }

        // GET: /Turtles/Details/5
        public IActionResult Details(int id)
        {
            var turtle = _turtleService.GetTurtleById(id);
            if (turtle == null)
            {
                return NotFound();
            }
            return View(turtle);
        }
    }
}
