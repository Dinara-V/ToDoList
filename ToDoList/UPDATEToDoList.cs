using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class UPDATEToDoList
    {
        MySQLDBConnection _connection;

        public UPDATEToDoList(MySQLDBConnection connection)
        {
            _connection = connection;
        }

        public void update(string id, string note, string status)
        {
            string query =$"UPDATE todolist SET note='{note}', status='{status}' " +
                $"WHERE id='{id}'";
            MySqlScript script = new MySqlScript(_connection.Connection, query);
            script.Execute();
        }
    }
}
