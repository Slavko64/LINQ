using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task21
    {
        //Дана строковая последовательность.Строки последовательности содержат только заглавные буквы латинского алфавита.Отсортировать последовательность по возрастанию длин строк, а строки одинаковой длины — в лексикографическом порядке по убыванию.
        static public string[] GetEnumerableString(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rand = new Random();
            string[] Arr = new string[n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < rand.Next(1, 15); j++)
                    Arr[i] += Alphabet[rand.Next(0, 26)].ToString();

            return Arr;
        }
        static public void Task()
        {
            Console.WriteLine("Task 21");
            var A = GetEnumerableString(100);
            var B = A.OrderBy(x => x.Length).ThenByDescending(x => x).ToList();

        }
    }
}
