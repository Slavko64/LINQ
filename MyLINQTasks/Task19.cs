using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task19
    {
//        Дана цифра D(целое однозначное число) и целочисленная последовательность A.Извлечь из A все различные положительные числа, оканчивающиеся цифрой D (в исходном порядке). При наличии повторяющихся элементов
//удалять все их вхождения, кроме последних.
        static public void Task()
        {
            Console.WriteLine("Task 19");
            int D = 8;
            var A = Program.GetEnumerableInt(100);
            var B = A.Where(x => x.ToString().Last() == D.ToString().First()).Reverse().Distinct().Reverse().ToList();

        }
    }
}
