using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task40
    {
        //        Дано число K(> 0) и строковая последовательность A.Получить последовательность символов, содержащую символы всех строк из A, имеющих длину, большую
        //или равную K (символы могут повторяться). В полученной
        //последовательности поменять порядок элементов на обратный.
        static public void Task()
        {
            Console.WriteLine("Task 40");
            int K = 4;
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = A.Where(x => x.Length >= K).SelectMany(x => x.Select(y => y)).Reverse().ToArray();

        }
    }
}
