using ChartDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChartDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowGraph()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetStudentData()
        {
            var data = new
            {
                labels = _context.Students.Select(s => s.Program).Distinct().ToList(),
                data = _context.Students
                    .GroupBy(s => s.Program)
                    .Select(g => g.Count())
                    .ToList()
            };
            return Json(data);
        }
    }
}
