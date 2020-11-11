using System;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
            MySQLConnectionString connStr;
            MySQLDBConnection mySQLDB;
            INSERT insert;
        private void button1_Click(object sender, EventArgs e)
        {
            connStr = new MySQLConnectionString("localhost", "root", "root", "testdb");
            mySQLDB = new MySQLDBConnection(connStr);
            INSERT insert = new INSERT(mySQLDB);

            if (passTB.Text == passTB2.Text)
            {
                DateTime now = DateTime.Now;

                User newUser = new User(loginTB.Text, passTB.Text, now.ToString("yyyy-MM-dd HH:mm:ss"));
                insert.Insert(newUser);
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }
    }
}
