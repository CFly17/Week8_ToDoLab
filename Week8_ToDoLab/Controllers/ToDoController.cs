using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8_ToDoLab.Models;

namespace Week8_ToDoLab.Controllers
{
    public class ToDoController : Controller
    {
        ToDoDAL tddb = new ToDoDAL();
        EmployeeDAL eDAL = new EmployeeDAL();

        public IActionResult Index()
        {
            List<ToDo> todos = tddb.GetToDos();
            return View(todos);
        }

        public IActionResult CreateToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDo(ToDo td)
        {
            return View(td);
        }

        public IActionResult EditToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditToDo(ToDo td)
        {
            return View(td);
        }

        public IActionResult AssignToDo(int id)
        {
            EmployeeTaskViewModel em = new EmployeeTaskViewModel();
            return View(em);
        }

        [HttpPost]
        public IActionResult AssignToDo(int id, int employeeId)
        {
            Assignment a = new Assignment();
            a.EmployeeId = employeeId;
            a.ToDoId = id;
            Employee em = eDAL.GetEmployee(employeeId);
            ToDo td = tddb.GetToDo(id);

            em.HoursAvailable = (em.HoursAvailable - td.HoursNeeded);
            AssignmentsDAL ad = new AssignmentsDAL();
            ad.CreateAssignment(a);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult MarkDone(int id)
        {
            ToDo td = tddb.GetToDo(id);
            return View(td);
        }
    }

}
