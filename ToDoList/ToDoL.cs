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
    public partial class ToDoL : Form
    {
        public ToDoL()
        {
            InitializeComponent();
        }
        string userId;
        public ToDoL(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }
        MySQLDBConnection mySQLDB;
        private void refreshDataGrid()
        {
            
            SELECT select = new SELECT(mySQLDB);
            select.Select(ToDoTable.TableName, "userId = '" + userId + "'");
            MyTasksDG.DataSource = select.Table;
        }

        private void ToDoL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewTaskBTN_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask(userId);
            newTask.ShowDialog();
        }

        private void ToDoL_Load(object sender, EventArgs e)
        {
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "testdb");
            mySQLDB = new MySQLDBConnection(connStr);
            refreshDataGrid();
        }
    }
}
