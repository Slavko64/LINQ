using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task5
    {
//        Дан символ С и строковая последовательность A.
//Найти количество элементов A, которые содержат более одного символа и при этом начинаются и оканчиваются символом C.
        static public void Task()
        {
            Console.WriteLine("Task 5");
            var C = 4;
            var A = Program.GetEnumerableString(1000);
            Program.Put(A.Count(X => X.Length > 1 && X.First() == C.ToString().First() && X.Last() == C.ToString().First()));
        }
    }
}
