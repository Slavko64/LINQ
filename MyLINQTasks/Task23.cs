using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task23
    {
        //Дано целое число K(> 0) и целочисленная последовательность A.Начиная с элемента A с порядковым номером K, извлечь из A все нечетные двузначные числа, отсортировав их по убыванию. 
        static public void Task()
        {
            Console.WriteLine("Task 23");
            int K = 10;
            var A = Program.GetEnumerableInt(100);
            var B = A.Skip(K).Where(x => x / 100 == 0 && x / 10 != 0 && x%2 != 0).OrderByDescending(y => y).ToArray();

        }
    }
}
