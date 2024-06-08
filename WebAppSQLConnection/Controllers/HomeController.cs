using Microsoft.AspNetCore.Mvc;
using WebAppSQLConnection.Models;

namespace WebAppSQLConnection.Controllers
{
    public class HomeController : Controller
    {
        List<Group> groups;

        public HomeController()
        {
            groups = new()
            {
                new() { Id = 1, Name = "NG01" },
                new() { Id = 2, Name = "NG02" },
            };
        }

        public IActionResult Index(int? groupId)
        {
            if (groupId == null)
            {
                return View(groups);
            }
            if (groups.Exists(g=>g.Id==groupId))
            {
                return View(groups.FirstOrDefault(g => g.Id == groupId));
            }
            return NotFound();
        }
    }
}
