using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task52
    {
        //        Даны строковые последовательности A и B; все
        //строки в каждой последовательности различны, имеют ненулевую длину и содержат только цифры и заглавные буквы
        //латинского алфавита.Получить последовательность всевозможных комбинаций вида «EA=EB», где EA — некоторый элемент из A, EB — некоторый элемент из B, причем оба элемента оканчиваются цифрой(например, «AF3= D78»). Упорядочить полученную последовательность в лексикографическом
        //порядке по возрастанию элементов EA, а при одинаковых
        //элементах EA — в лексикографическом порядке по убыванию
        //элементов EB.
        //Указание.Для перебора комбинаций использовать методы
        //SelectMany и Select.
        static public void Task()
        {
            Console.WriteLine("Task 52");
            Random rand = new Random();
            var A = Program.GetEnumerableStringWithLetters(50, rand);
            var B = Program.GetEnumerableStringWithLetters(50, rand);
            var C = A.Where(x => char.IsDigit(x.Last()) == true).Select(x => x).Join(B.Where(x => char.IsDigit(x.Last()) == true).Select(x => x), x => x, y => y, (x, y) => x + "=" + y).ToArray();

        }
    }
}
