using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task36
    {
        //        Дана последовательность непустых строк.Получить последовательность символов, которая определяется
        //следующим образом: если соответствующая строка исходной
        //последовательности имеет нечетную длину, то в качестве
        //символа берется первый символ этой строки; в противном
        //случае берется последний символ строки.Отсортировать полученные символы по убыванию их кодов.
        static public void Task()
        {
            Console.WriteLine("Task 36");
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = A.Where(x => x.Length % 2 != 0).Select(x => x.First()).Union(A.Where(x => x.Length % 2 == 0).Select(x => x.Last())).OrderByDescending(x => x).ToArray();

        }
    }
}
