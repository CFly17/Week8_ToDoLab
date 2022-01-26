using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_ToDoLab.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0, 60)]
        public float HoursAvailable { get; set; }
        public string Title { get; set; }
        public List<ToDo> ToDoList { get; set; }
    }
}
