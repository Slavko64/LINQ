using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task32
    {
        //        Дана последовательность непустых строк A.Получить последовательность символов, каждый элемент которой является начальным символом соответствующей строки
        //из A.Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.
        static public void Task()
        {
            Console.WriteLine("Task 32");
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = A.Select(x => x.First()).Reverse().ToArray();
        }
    }
}
