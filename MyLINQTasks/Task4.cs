using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task4
    {
//        Дан символ С и строковая последовательность A.
//Если A содержит единственный элемент, оканчивающийся
//символом C, то вывести этот элемент; если требуемых строк
//в A нет, то вывести пустую строку; если требуемых строк
//больше одной, то вывести строку «Error». 
        static public void Task()
        {
            Console.WriteLine("Task 4");
            int C = 4;
            var A = Program.GetEnumerableString(10);
            try
            {
                Program.Put(A.SingleOrDefault(x => x[x.Length - 1] == C.ToString()[0]));
            }
            catch(Exception e)
            {
                if(e.Message.Length > 0)
                    Program.Put("Error");
                else
                    Program.Put("");
            }
        }
    }
}
