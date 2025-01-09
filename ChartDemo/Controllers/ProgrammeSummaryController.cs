using ChartDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChartDemo.Controllers
{
    public class ProgrammeSummaryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgrammeSummaryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowChart()
        {
            return View();
        }
    }
}
