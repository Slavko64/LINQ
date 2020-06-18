using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task8
    {
//        Дана целочисленная последовательность.Найти
//количество ее положительных двузначных элементов, а также их среднее арифметическое(как вещественное число).
//Если требуемые элементы отсутствуют, то дважды вывести 0
//(первый раз как целое, второй — как вещественное). 
        static public void Task()
        {
            Console.WriteLine("Task 8");
            var A = Program.GetEnumerableInt(1000);
            try
            {
                Program.Put(A.Count(x => x > 0) + "\n" + A.Where(x => x > 0).Average());
            }
            catch
            {
                Program.Put("0\n0,0");
            }
        }
    }
}
