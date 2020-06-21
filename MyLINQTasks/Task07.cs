using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task7
    {
//        Дана целочисленная последовательность.Найти
//количество ее отрицательных элементов, а также их сумму.
//Если отрицательные элементы отсутствуют, то дважды вывести 0. 
        static public void Task()
        {
            Console.WriteLine("Task 7");
            var A = Program.GetEnumerableInt(1000);
            Program.Put(A.Count(x => x < 0) + "\n" + A.Where(x => x < 0).Sum());
        }
    }
}
