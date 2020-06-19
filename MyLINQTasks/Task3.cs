using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task3
    {
        //Дано целое число L(> 0) и строковая последовательность A.Вывести последнюю строку из A, начинающуюся с цифры и имеющую длину L.Если требуемых строк в последовательности A нет, то вывести строку «Not found». 
        static public void Task()
        {
            Console.WriteLine("Task 3");
            int L = 4;
            var A = Program.GetEnumerableString(100);
            try
            {
                Program.Put(A.Last(x => x.First() == L.ToString().First()));
            }
            catch
            {
                Program.Put("Not found");
            }
        }
    }
}
