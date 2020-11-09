using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    interface ITable
    {
        List<string> GetColumnNames();
        string GetTableName();
        List<string> GetData();
    }
}
