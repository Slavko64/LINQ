using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task35
    {
        //        Дана целочисленная последовательность.Получить последовательность чисел, каждый элемент которой равен произведению соответствующего элемента исходной последовательности на его порядковый номер(1, 2, …). В полученной последовательности удалить все элементы, не являющиеся двузначными, и поменять порядок оставшихся
        //элементов на обратный
        static public void Task()
        {
            Console.WriteLine("Task 35");
            var A = Program.GetEnumerableInt(50);
            var B = A.Select((x,index) => x*(index+1)).Where(x => Math.Abs(x).ToString().Length != 2).Reverse().ToArray();
        }
    }
}
