using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task13
    {
//        Дано целое число N(> 0). Используя методы
//Range и Sum, найти сумму 1 + (1/2) + … + (1/N) (как вещественное число). 
        static public void Task()
        {
            Console.WriteLine("Task 13");
            const int N = 100;
            Program.Put("" + Enumerable.Range(1, N).Sum(x => 1 / (double)x));
        }
    }
}
