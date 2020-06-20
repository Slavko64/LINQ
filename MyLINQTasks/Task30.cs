using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task30
    {
        //        Дано целое число K(> 0) и целочисленная последовательность A.Найти теоретико-множественную разность двух фрагментов A: первый содержит все четные числа, а второй — все числа с порядковыми номерами, большими K. В полученной последовательности (не содержащей
        //одинаковых элементов) поменять порядок элементов на обратный.
        static public void Task()
        {
            Console.WriteLine("Task 30");
            int K = 5;
            var A = Program.GetEnumerableInt(10);
            var B = A.Where(x => x%2 == 0).Except(A.Skip(K)).Distinct().Reverse().ToArray();
        }
    }
}
