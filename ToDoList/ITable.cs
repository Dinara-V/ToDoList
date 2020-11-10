using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //интерфейс, объединяющий класс User и ToDoTable
    interface ITable
    {
        List<string> GetColumnNames();
        string GetTableName();
        List<string> GetData();
    }
}
