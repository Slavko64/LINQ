using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task34
    {
        //        Дана последовательность положительных целых
        //чисел.Обрабатывая только нечетные числа, получить последовательность их строковых представлений и отсортировать
        //ее в лексикографическом порядке по возрастанию.
        static public int[] GetEnumerablePositiveInt(int n)
        {
            Random rand = new Random();
            int[] Arr = new int[n];

            for (int i = 0; i < n; i++)
                Arr[i] = rand.Next(0, 100);

            return Arr;
        }
        static public void Task()
        {
            Console.WriteLine("Task 34");
            var A = GetEnumerablePositiveInt(50);
            var B = A.Where(x => x %2 != 0).Select(x => x.ToString()).OrderBy(x => x).ToArray();
        }
    }
}
