using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int Id, string name, string surname, int age)
        {
            return Content($"{Id} {name} {surname} {age}");
        }

        public IActionResult About()
        {
            ViewBag.Name = "Tural";
            ViewData["Surname"] = "Cavadov";
            TempData["Age"] = 25;
            // return RedirectToAction(nameof(Contact));// or return RedirectToAction("Contact")--ferqi nameofla sehvsiz uzantisini neyi istesen gorursenn

            //ViewBag.Students = students;

            List<Student> students = new List<Student> {
            new Student{Id=1,Name="Tural",Surname="Cavadov" },
            new Student{ Id=2,Name="Ulvi",Surname="Mecidli "},
            };

            List<Group> groups = new List<Group>
            {
                new Group{ Id=1,grName="P322"},
                new Group{ Id=2,grName="P111"},
            };

           // ViewBag.Groups = groups;

            HomeVM homevm=new HomeVM();
            homevm.Groups = groups;
            homevm.Students = students;
          
            return View(homevm);
        }
        public IActionResult Contact()
        {
            return View();

        }
    }
}
