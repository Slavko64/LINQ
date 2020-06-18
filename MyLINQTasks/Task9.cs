using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task9
    {
//        Дана целочисленная последовательность.Вывести
//ее минимальный положительный элемент или число 0, если
//последовательность не содержит положительных элементов.
        static public void Task()
        {
            Console.WriteLine("Task 9");
            var A = Program.GetEnumerableInt(1);
            try
            {
                Program.Put(A.Where(x => x > 0).Min());
            }
            catch
            {
                Program.Put("0");
            }
        }
    }
}
