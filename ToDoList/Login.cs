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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySQLConnectionString connStr;
        MySQLDBConnection mySQLDB;
        SELECT select;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            select.Select(User.TableName, "user='" + TBName.Text + "' and pass = '" + TBPass.Text + "'");
            if (select.TableToList(0) != null)
            {
                User loginUser = new User(select.TableToList(0));
                ToDoL toDo = new ToDoL(loginUser.Id);
                toDo.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connStr=new MySQLConnectionString("localhost", "root", "root", "testdb");
            mySQLDB = new MySQLDBConnection(connStr);
            select = new SELECT(mySQLDB);
            /*User test = new User("upload", "upload", "2020-02-01");
            INSERT insert = new INSERT(mySQLDB);
            insert.Insert(test);*/
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             MySQLConnectionString connStr =
                 new MySQLConnectionString("localhost", "root", "root", "testdb");
             

             SELECT select = new SELECT(mySQLDB);
             User test = new User();
             test.getDataFromList(select.select("logins","id=3"));
             MessageBox.Show(test.Id + " " + test.UserName + " " + test.Date);
         }*/
    }
}
