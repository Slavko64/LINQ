using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task33
    {
        //Дана целочисленная последовательность.Обрабатывая только положительные числа, получить последовательность их последних цифр и удалить в полученной последовательности все вхождения одинаковых цифр, кроме первого.Порядок полученных цифр должен соответствовать порядку исходных чисел.
        static public void Task()
        {
            Console.WriteLine("Task 33");
            var A = Program.GetEnumerableInt(50);
            var B = A.Where(x=> x>0).Select(x =>x%10).ToArray();
        }
    }
}
