﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_ToDoLab.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public int AssignedTo { get; set; }
        public float HoursNeeded { get; set; }
        public bool IsCompleted { get; set; }

    }
}
