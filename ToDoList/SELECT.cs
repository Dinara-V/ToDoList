using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ToDoList
{
    class SELECT
    {
        MySQLDBConnection _connection;
        public DataTable Table { get; private set; }
        public SELECT(MySQLDBConnection connection)
        {
            _connection = connection;
            Table = new DataTable();
        }

        //берём данные из базы данных и заливаем их в таблицу
        public void Select(string TableName, string options="1")
        {
            string query = "SELECT * FROM " + TableName+" WHERE "+options;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, _connection.Connection);
            Table.Clear();
            dataAdapter.Fill(Table);
        }
        //превращаем строку таблицы в список (List) строк 
        public List<string> TableToList(int index)
        {
            if (index < Table.Rows.Count)
            {
                List<string> result = new List<string>();
                DataRow row = Table.Rows[index];
                int len = row.ItemArray.Length;
                for (int i = 0; i < len; i++)
                    result.Add(row.ItemArray[i].ToString());
                return result;
            }
            return null;
        }
    }
}
