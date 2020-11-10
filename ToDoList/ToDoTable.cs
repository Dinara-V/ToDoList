using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    class ToDoTable:ITable
    {
        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string Name { get; set; }
        public string Note { private get; set; }
        public string DeadLine { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Url { get; set; }
        static public string TableName = "todolist";

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
            userData.Add(UserId);
            userData.Add(Name);
            userData.Add(Note);
            userData.Add(DeadLine);
            userData.Add(Status);
            userData.Add(Priority);
            userData.Add(Url);
            return userData;
        }
        /*метод, создающий список строк с именами колонок
        */
        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("userID");
            ColumnNames.Add("name");
            ColumnNames.Add("note");
            ColumnNames.Add("deadline");
            ColumnNames.Add("status");
            ColumnNames.Add("priority");
            ColumnNames.Add("url");

        }

        public ToDoTable(
            string UserId,
            string Name,
            string Note,
            string DeadLine,
            string Status,
            string Priority,
            string Url)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.Note = Note;
            this.DeadLine = DeadLine;
            this.Status = Status;
            this.Priority = Priority;
            this.Url = Url;

            SetColumnNames();
        }

        public ToDoTable(List<string> UserData)
        {
            GetDataFromList(UserData);
            SetColumnNames();
        }
        //метод, позволяющий заполнить поля объекта класса ToDoTable с помощью списка строк
        public void GetDataFromList(List<string> UserData)
        {
            Id = UserData[0];
            UserId = UserData[1];
            Name = UserData[2];
            Note = UserData[3];
            DeadLine = UserData[4];
            Status = UserData[5];
            Priority = UserData[6];
            Url = UserData[7];
        }
    }
}
