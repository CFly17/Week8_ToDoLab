using Dapper;
using Microsoft.AspNetCore.DataProtection;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;

namespace Week8_ToDoLab.Models
{
    public class ToDoDAL
    {
        public List<ToDo> GetToDos()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from todos";
                connect.Open();
                List<ToDo> toDos = connect.Query<ToDo>(sql).ToList();
                connect.Close();
                return toDos;
            }
        }

        public ToDo GetToDo(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from todos where id =" +id;
                connect.Open();
                ToDo toDo = connect.Query<ToDo>(sql).ToList().First();
                connect.Close();
                return toDo;
            }
        }

        public void AddToDo(ToDo t)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into todos values(0, null, '{t.Name}', '{t.Description}', {t.HoursNeeded}, {t.IsCompleted})";
                connect.Open();
                ToDo toDo = connect.Query<ToDo>(sql).ToList().First();
                connect.Close();
            }
        }
        public void EditToDo(ToDo t)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update todos set assignedto = {t.AssignedTo}, name = '{t.Name}', description = '{t.Description}', hoursneeded = {t.HoursNeeded}, iscompleted = {t.IsCompleted})";
                connect.Open();
                ToDo toDo = connect.Query<ToDo>(sql).ToList().First();
                connect.Close();
            }
        }

        public void CreateToDo(ToDo td)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into todos values(0, null, name = '{td.Name}', " +
                    $"description = '{td.Description}', hoursNeeded = {td.HoursNeeded}, false)";
                connect.Open();
                connect.Query<ToDo>(sql);
                connect.Close();
            }
        }

        public void MarkDone(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "update todos set iscompleted = true where id = " + id;
                connect.Open();
                connect.Query<ToDo>(sql);
                connect.Close();
            }
        }

    }
}

