using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task31
    {
        //        Дано целое число K(> 0) и последовательность
        //непустых строк A.Строки последовательности содержат
        //только цифры и заглавные буквы латинского алфавита.Найти теоретико-множественное пересечение двух фрагментов
        //A: первый содержит K начальных элементов, а второй — все
        //элементы, расположенные после последнего элемента, оканчивающегося цифрой. Полученную последовательность (не
        //содержащую одинаковых элементов) отсортировать по возрастанию длин строк, а строки одинаковой длины — в лексикографическом порядке по возрастанию.
        static public void Task()
        {
            Console.WriteLine("Task 31");
            int K = 49;
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = A.Take(K).Intersect(A.SkipWhile(x=>x != A.Last(y => char.IsDigit(y.Last()) == true))).Distinct().OrderBy(x => x.Length).ThenBy(x => x).ToArray();
        }
    }
}
