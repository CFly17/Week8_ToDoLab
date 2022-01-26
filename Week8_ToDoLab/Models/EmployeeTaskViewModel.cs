using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_ToDoLab.Models
{
    public class EmployeeTaskViewModel
    {
        //view models only exist on views, often used to show off multiple model classes simultaneously
        //or to move small pieces of data from controller to view

        public List <ToDo> toDos { get; set; }
        public List <Employee> Employees { get; set; }
        public EmployeeTaskViewModel()
        {
            ToDoDAL tdDAL = new ToDoDAL();
            EmployeeDAL eDAL = new EmployeeDAL();
            toDos = tdDAL.GetToDos();
            Employees = eDAL.GetEmployees();
        }
    }
}
