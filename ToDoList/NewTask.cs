﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }
        string Uid;
        public NewTask(string UserId)
        {
            Uid = UserId;
            InitializeComponent();
        }
        /*при клике на кнопку "Добавить" создаём экземпляр класса ToDoTable с входными данными из формы
         * NewTask, создаём новое подключение, создаём экземпляр класса INSERT и вызываем метод, чтобы
         * ввести данные из формы в таблицу в базе данных
         */
        private void OkBTN_Click(object sender, EventArgs e)
        {
            ToDoTable newTask = new ToDoTable(Uid, NameTB.Text, NoteTB.Text,
                DeadLinePicker.Value.ToString("yyyy-MM-dd"), "не начато",
                PriorityUpDown.Value.ToString(),UrlTB.Text);
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "testdb");
            MySQLDBConnection mySQLDB = new MySQLDBConnection(connStr);

            INSERT insertTask = new INSERT(mySQLDB);
            insertTask.Insert(newTask);
            Close();
        }
    }
}
