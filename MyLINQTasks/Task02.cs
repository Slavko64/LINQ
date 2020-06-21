using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task2
    {
        // Дана цифра D(однозначное целое число) и целочисленная последовательность A.Вывести первый положительный элемент последовательности A, оканчивающийся
        //цифрой D.Если требуемых элементов в последовательности
        //A нет, то вывести 0. 
        static public void Task()
        {
            Console.WriteLine("Task 2");
            int n = 3;
            var A = Program.GetEnumerableInt(100);
            Program.Put(A.FirstOrDefault(x => x.ToString().Last() == n.ToString().First()));
        }
    }
}
