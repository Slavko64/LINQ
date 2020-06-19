using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task26
    {
        //        Даны целые числа K1 и K2 и последовательность
        //непустых строк A; 1 < K1<K2 ≤ N, где N — размер последовательности A.Найти среднее арифметическое длин всех
        //элементов последовательности, кроме элементов с порядковыми номерами от K1 до K2 включительно, и вывести его как
        //вещественное число.
        static public void Task()
        {
            Console.WriteLine("Task 26");
            int K1 = 4, K2 = 6;
            var A = Program.GetEnumerableString(10);
            var B = A.Where((x,index) => index < K1 || index > K2).Average(x => x.Length);
            Program.Put("" + B);
        }
    }
}
