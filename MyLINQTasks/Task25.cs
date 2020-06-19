using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task25
    {
        //        Дано целое число K(> 0) и строковая последовательность A.Из элементов A, предшествующих элементу с
        //порядковым номером K, извлечь те строки, которые имеют
        //нечетную длину и начинаются с заглавной латинской буквы,
        //изменив порядок следования извлеченных строк на обратный.
        static public void Task()
        {
            Console.WriteLine("Task 24");
            int K1 = 4, K2 = 6;
            var A = Program.GetEnumerableInt(10);
            var B = A.Skip(K1).Take(K2-K1).Where(x => x>0).Sum(y=>y);
            Program.Put(B);
        }
    }
}
