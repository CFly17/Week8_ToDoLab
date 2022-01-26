using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8_ToDoLab.Models;

namespace Week8_ToDoLab.Controllers
{
    //This will act as a 'manager' for the employee table
    public class EmployeeController : Controller
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        ToDoDAL dbToDo = new ToDoDAL();
        public IActionResult Index()
        {
            EmployeeTaskViewModel etvm = new EmployeeTaskViewModel();
            return View(etvm);
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult UpdateEmployee(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee e)
        {
            dbEmployee.UpdateEmployee(e);
            return View(e);
        }
        public IActionResult DeleteEmployee(int id)
        {
            dbEmployee.DeleteEmployee(id);
            return RedirectToAction("Index", "Employee");
        }

    }
}
