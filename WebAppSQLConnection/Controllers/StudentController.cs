using Microsoft.AspNetCore.Mvc;
using WebAppSQLConnection.Models;

namespace WebAppSQLConnection.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students;
        public StudentController()
        {
            students = new()
            {
                new() { Id = 1, Name = "John", GroupId = 1 },
                new() { Id = 2, Name = "James", GroupId = 1 },
                new() { Id = 3, Name = "Jack", GroupId = 1 },
                new() { Id = 4, Name = "Bill", GroupId = 2 },
                new() { Id = 5, Name = "Ben", GroupId = 2 },
                new() { Id = 6, Name = "Brian", GroupId = 2 },
            };
        }

        public IActionResult Index(int? groupId)
        {
            if (groupId == null) 
            {
                return View(students);
            }
            if (students.Exists(s=>s.GroupId == groupId))
            {
                return View(students.FindAll(s => s.GroupId == groupId));
            }
            return NotFound();
        }
    }
}