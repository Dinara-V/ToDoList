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

        //в конструкторе создаём подключение и открываем его
        public MySQLDBConnection(IConnectionString ConnString)
        {
            Connection = new MySqlConnection(ConnString.ConnectionString());
            Connection.Open();
        }

        //метод для закрытия подключения
        public void Dispose()
        {
            Connection.Close();
        }
    }
}
