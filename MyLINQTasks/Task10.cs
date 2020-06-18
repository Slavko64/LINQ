using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task10
    {
//        Дано целое число L(> 0) и строковая последовательность A.Строки последовательности A содержат только
//заглавные буквы латинского алфавита. Среди всех строк из
//A, имеющих длину L, найти наибольшую (в смысле лексикографического порядка). Вывести эту строку или пустую
//строку, если последовательность не содержит строк длины L.
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
            Console.WriteLine("Task 10");
            int L = 4;
            var A = GetEnumerableString(100);
                 Program.Put(A.Where(x => x.Length == L).Max());
        }
    }
}
