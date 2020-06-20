using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task38
    {
        //        Дана целочисленная последовательность A.Получить новую последовательность чисел, элементы которой
        //определяются по соответствующим элементам последовательности A следующим образом: если порядковый номер
        //элемента A делится на 3 (3, 6, …), то этот элемент в новую
        //последовательность не включается; если остаток от деления
        //порядкового номера на 3 равен 1 (1, 4, …), то в новую последовательность добавляется удвоенное значение этого элемента; в противном случае(для элементов A с номерами 2,
        //5, …) элемент добавляется в новую последовательность без
        //изменений.В полученной последовательности сохранить исходный порядок следования элементов.
        static public void Task()
        {
            Console.WriteLine("Task 38");
            var A = Program.GetEnumerableInt(50);
            var B = A.SelectMany((x, index) =>
            {
                if (index % 3 == 1)
                    return new[] { x * 2 };
                else if (index % 3 != 0)
                    return new[] { x };
                else return Enumerable.Empty<int>();
            }).ToArray();

        }
    }
}
