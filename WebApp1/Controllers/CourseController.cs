using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class CourseController : Controller
    {
        List<Candidate> candidates = new List<Candidate>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            candidates.Add(candidate);
            return Ok(candidates);
        }
    }
}
