using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task45
    {
        //        Даны целые положительные числа L1 и L2 и строковые последовательности A и B.Строки последовательностей содержат только цифры и заглавные буквы латинского
        //алфавита.Получить последовательность, содержащую все
        //строки из A длины L1 и все строки из B длины L2. Отсортировать полученную последовательность в лексикографическом
        //порядке по убыванию. 
        static public void Task()
        {
            Console.WriteLine("Task 45");
            int L1 = 3, L2 = 4;
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = Program.GetEnumerableStringWithLetters(50);
            var C = A.Where(x => x.Length == L1).Concat(B.Where(x => x.Length == L2)).OrderByDescending(x => x).ToArray();

        }
    }
}
