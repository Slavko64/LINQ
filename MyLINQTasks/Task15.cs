using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task15
    {
//        Дано целое число N(0 ≤ N ≤ 15). Используя методы Range и Aggregate, найти факториал числа N:
//N! = 1·2·…·N при N ≥ 1; 0! = 1. 
        static public void Task()
        {
            Console.WriteLine("Task 15");
            const int N = 10;
            try
            {
                Program.Put("" + Enumerable.Range(1, N).Aggregate((x, y) => x * y));
            }
            catch
            {
                Program.Put(1);
            }
        }
    }
}
