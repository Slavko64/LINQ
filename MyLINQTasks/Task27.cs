using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task27
    {
        //Дано целое число D и целочисленная последовательность A.Начиная с первого элемента A, большего D, извлечь из A все нечетные положительные числа, поменяв порядок извлеченных чисел на обратный. 
        static public void Task()
        {
            Console.WriteLine("Task 27");
            int D = 20;
            var A = Program.GetEnumerableInt(10);
            var B = A.SkipWhile(x => x < D).Where(x => x % 2 != 0 && x > 0).OrderByDescending(x => x).ToArray();
        }
    }
}
