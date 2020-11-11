using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        string url;
        string id;
        public ToDoL(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }
        MySQLDBConnection mySQLDB;

        /*
         * берём из таблицы в базе данных все записи, соответствующие вошедшему пользователю,
         * и заливаем их в DataGrig
         */
        private void refreshDataGrid(string query)
        {
            
            SELECT select = new SELECT(mySQLDB);
            select.Select(query);
            MyTasksDG.DataSource = select.Table;
        }
        //закрываем всю программу при закрытии окна
        private void ToDoL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //инициализируем форму для создания новой задачи и показываем её в виде диалога
        private void NewTaskBTN_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask(userId);
            newTask.ShowDialog();
            refreshDataGrid("SELECT id, name, priority, " +
                "status, deadline from todolist WHERE userId=" + userId);
        }
        //при загрузке формы инициализируем connStr, mySQLDB и заливаем из базы данных данные в DataGrid
        private void ToDoL_Load(object sender, EventArgs e)
        {
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "testdb");
            mySQLDB = new MySQLDBConnection(connStr);
            refreshDataGrid("SELECT id, name, priority, " +
                "status, deadline from todolist WHERE userId=" + userId);
        }

        private void MyTasksDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = MyTasksDG[0, index].Value.ToString();
                SELECT select = new SELECT(mySQLDB);
                select.Select("SELECT note, status, url FROM todolist WHERE id=" + id);
                noteRT.Text = select.Table.Rows[0].ItemArray[0].ToString();
                statusCB.Text= select.Table.Rows[0].ItemArray[1].ToString();
                url = select.Table.Rows[0].ItemArray[2].ToString();
            }
        }

        private void DownloadBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog()==DialogResult.OK)
            {
                Downloader dwnload = new Downloader(url, folderBrowser.SelectedPath);
                if (dwnload.DownloadFile())
                {
                    MessageBox.Show("Скачано!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            UPDATEToDoList update = new UPDATEToDoList(mySQLDB);
            update.update(id, noteRT.Text, statusCB.Text);
            refreshDataGrid("SELECT id, name, priority, " +
                "status, deadline from todolist WHERE userId=" + userId);
        }
    }
}
