using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_ToDoLab.Models
{
    
    //This is the mode lfor our many-to-many
    //Each employee can have multiple to-dos
    //each to-do can have multiple employees
    //each row in this table links a to-do with an employee
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ToDoId { get; set; }
        public Employee Employee { get; set; }
        public ToDo ToDo { get; set; }
    }
}
