﻿using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_ToDoLab.Models
{
    public class AssignmentsDAL
    {
        public void CreateAssignment (Assignment a)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into todos values(0, {a.EmployeeId}, {a.ToDoId})";
                connect.Open();
                connect.Query<Assignment>(sql);
                connect.Close();
            }
        }
    }
}
