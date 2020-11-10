using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class INSERT
    {
        MySQLDBConnection _connection;

        public INSERT(MySQLDBConnection connection)
        {
            _connection = connection;
        }
        /*получаем из таблицы названия колонок, данные пользователя и название таблицы,
         * в которую следует добавить новые данные, создаём команду INSERT для базы данных,
         * универсальную для любого реализующего интерфейс ITable класса
         */
        public void Insert(ITable row)
        {
            List<string> columnNames = row.GetColumnNames();
            List<string> userData = row.GetData();
            string tableName = row.GetTableName();
            int n = columnNames.Count;
            string query = "INSERT INTO " + tableName + "(";
            for(int i=0;i<n;i++)
            {
                query += columnNames[i];
                if (i != n - 1)
                    query += ", ";
            }
            query += ") VALUES (";

            for (int i = 0; i < n; i++)
            {
                if (userData[i]=="null"||userData[i]=="NULL"||userData[i]=="")
                {
                    query += "null";
                }
                else 
                {
                    query += "'" + userData[i] + "'";
                }
                if (i != n - 1)
                    query += ", ";
            }
            query += ")";

            MySqlScript script = new MySqlScript(_connection.Connection, query);
            script.Execute();
        }
    }
}
