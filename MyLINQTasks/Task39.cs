using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task39
    {
        //        Дана строковая последовательность A.Получить
        //последовательность цифровых символов, входящих в строки
        //последовательности A (символы могут повторяться). Порядок символов должен соответствовать порядку строк A и порядку следования символов в каждой строке.
        //Указание.Использовать метод SelectMany с учетом того,
        //что строка может интерпретироваться как последовательность символов.
        static public void Task()
        {
            Console.WriteLine("Task 39");
            var A = Program.GetEnumerableStringWithLetters(50);
            var B = A.SelectMany(x => x.Where(y => char.IsDigit(y) == true).Select(y => y)).ToArray();

        }
    }
}
