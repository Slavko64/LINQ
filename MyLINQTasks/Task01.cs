using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task01 
    {
        //Дана целочисленная последовательность, содержащая как положительные, так и отрицательные числа.Вывести ее первый положительный элемент и последний отрицательный элемент. 
        static public void Task()
        {
            Console.WriteLine("Task 1");
            var a = Program.GetEnumerableInt(100);
            Program.Put(a.First(x => x > 0));
            Program.Put(a.Last(x => x < 0));
        }
    }
}
