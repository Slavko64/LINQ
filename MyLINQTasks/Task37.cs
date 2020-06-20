using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task37
    {
        //        Дана строковая последовательность A.Строки
        //последовательности содержат только заглавные буквы латинского алфавита.Получить новую последовательность
        //строк, элементы которой определяются по соответствующим
        //элементам A следующим образом: пустые строки в новую
        //последовательность не включаются, а к непустым приписывается порядковый номер данной строки в исходной последовательности (например, если пятый элемент A имеет вид
        //«ABC», то в полученной последовательности он будет иметь
        //вид «ABC5»). При нумерации должны учитываться и пустые
        //строки последовательности A.Отсортировать полученную
        //последовательность в лексикографическом порядке по возрастанию.
        static public void Task()
        {
            Console.WriteLine("Task 37");
            var A = Program.GetEnumerableOnlyLetters(50);
            var B = A.Where(x => x != null /*|| x.Length > 0*/).Select((x, index) =>x + (index+1)).OrderBy(x=>x).ToArray(); // i cant create empty string.. sorry

        }
    }
}
