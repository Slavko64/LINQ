using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task12
    {
//        Дана целочисленная последовательность.Используя метод Aggregate, найти произведение последних
//цифр всех элементов последовательности.
        static public void Task()
        {
            Console.WriteLine("Task 12");
            var A = Program.GetEnumerableInt(10);
            int product = A.First() % 10;
            A.Aggregate((x, y) => product *= y%10);
            Program.Put(Math.Abs(product));
        }
    }
}
