using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task14
    {
//        Даны целые числа A и B(A<B). Используя методы Range и Average, найти среднее арифметическое квадратов всех целых чисел от A до B включительно:
//         (A2 + (A+1)2 + … + B2/)/(B − A + 1) (как вещественное число). 
        static public void Task()
        {
            Console.WriteLine("Task 14");
            const int A = 5;
            const int B = 10;
            Program.Put("" + Enumerable.Range(A, B).Average(x => x*x/(B-A+1)));
        }
    }
}
