using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task44
    {
        //        Даны целые числа K1 и K2 и целочисленные последовательности A и B.Получить последовательность, содержащую все числа из A, большие K1, и все числа из B,
        //меньшие K2. Отсортировать полученную последовательность
        //по возрастанию.
        static public void Task()
        {
            Console.WriteLine("Task 44");
            int K1 = 55, K2 = 45;
            var A = Program.GetEnumerableInt(50);
            var B = Program.GetEnumerableInt(50);
            var C = A.Where(x => x > K1).Concat(B.Where(x => x < K2)).OrderBy(x => x).ToArray();
        }
    }
}
