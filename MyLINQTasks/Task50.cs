using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task50
    {
        //        Даны строковые последовательности A и B; все
        //строки в каждой последовательности различны и имеют ненулевую длину.Получить последовательность строк вида
        //«E:N», где E обозначает один из элементов последовательности A, а N — количество элементов из B, начинающихся с того же символа, что и элемент E (например, «abc:4»); количество N может быть равно 0. Порядок элементов полученной
        //последовательности должен определяться исходным порядком элементов последовательности A.
        //Указание.Использовать метод GroupJoin.
        static public void Task()
        {
            Console.WriteLine("Task 50");
            Random rand = new Random();
            var A = Program.GetEnumerableStringWithLetters(100, rand);
            var B = Program.GetEnumerableStringWithLetters(100, rand);
            var C = A.GroupJoin(B, x => x.First(), y => y.First(), (x, y) => x + ":" + y.Count()).ToArray();

        }
    }
}
