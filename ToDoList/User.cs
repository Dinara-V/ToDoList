using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class User:ITable
    {
        public string Id { get; private set; }
        public string UserName { get;  set; }
        public string Pass { private get; set; }
        public string Date{ get; set; }
        static public string TableName = "logins";

        public List<string> ColumnNames;
        //метод для получения названий колонок
        public List<string> GetColumnNames()
        {
            return ColumnNames;
        }
        //метод для получения имени таблицы
        public string GetTableName()
        {
            return TableName;
        }
        /*метод, создающий список строк, который заполняет данными,
 * полученными при инициализации, и возвращающий этот список
 */
        public List<string> GetData()
        {
            List<string> userData = new List<string>();
            if (Id == null)
                Id = "NULL";
            userData.Add(Id);
            userData.Add(UserName);
            userData.Add(Pass);
            userData.Add(Date);
            return userData;
        }

        /*метод, создающий список строк с именами колонок
*/
        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("user");
            ColumnNames.Add("pass");
            ColumnNames.Add("regDate");

        }

        public User(string UserName, string Password, string RegDate)
        {
            this.UserName = UserName;
            Pass = Password;
            Date = RegDate;
            SetColumnNames();
        }
        public User(List<string> UserData)
        {
            GetDataFromList(UserData);
            SetColumnNames(); 
        }
        //метод, позволяющий заполнить поля объекта класса User с помощью списка строк
        public void GetDataFromList(List<string> UserData)
        {
            Id = UserData[0];
            UserName = UserData[1];
            Pass = UserData[2];
            Date = UserData[3];
            
        }
    }
}
