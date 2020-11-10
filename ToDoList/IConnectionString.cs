using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //создаём шаблон для создания строки описания подключения в дочерних классах
    interface IConnectionString
    {
        string ConnectionString();
    }
}
