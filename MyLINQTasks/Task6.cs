using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task6
    {
//        Дана строковая последовательность.Найти сумму
//длин всех строк, входящих в данную последовательность.
        static public void Task()
        {
            Console.WriteLine("Task 6");
            var A = Program.GetEnumerableString(1000);
            Program.Put(A.Sum(X => X.Length));
        }
    }
}
