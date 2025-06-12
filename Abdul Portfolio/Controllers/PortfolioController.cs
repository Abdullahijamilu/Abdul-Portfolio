using Abdul_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project { Title = "HRMS App", Description = "HR Management System using ASP.NET Core.", GitHubUrl = "https://github.com/yourname/hrms" },
                new Project { Title = "Todo App", Description = "A todo tracker built with MVC.", GitHubUrl = "https://github.com/yourname/todo" }
            };

            return View(projects);
        }

        public IActionResult Blog() => View();

        public IActionResult Contact() => View();
    }
}
