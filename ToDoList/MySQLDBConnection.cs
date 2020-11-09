using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class MySQLDBConnection : IDisposable
    {
        public MySqlConnection Connection { get; private set; }
        public MySQLDBConnection(IConnectionString ConnString)
        {
            Connection = new MySqlConnection(ConnString.ConnectionString());
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
