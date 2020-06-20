using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task29
    {
        //        Даны целые числа D и K(K > 0) и целочисленная
        //последовательность A.Найти теоретико-множественное объединение двух фрагментов A: первый содержит все элементы
        //до первого элемента, большего D (не включая его), а второй
        //— все элементы, начиная с элемента с порядковым номером
        //K.Полученную последовательность (не содержащую одинаковых элементов) отсортировать по убыванию.
        static public void Task()
        {
            Console.WriteLine("Task 29");
            int D = 20 , K = 5;
            var A = Program.GetEnumerableInt(10);
            var B = A.TakeWhile(x => x < D).Union(A.Skip(K)).Distinct().OrderByDescending(x => x).ToArray();
        }
    }
}
