using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task28
    {
        static public string[] GetEnumerableString(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rand = new Random();
            string[] Arr = new string[n];
            int length;
            for (int i = 0; i < n; i++)
            {
                length = rand.Next(1, 6);
                for (int j = 0; j < length; j++)
                {
                    if (rand.Next(1, 3) == 1)
                        Arr[i] += Alphabet[rand.Next(0, 26)].ToString();
                    else
                        Arr[i] += rand.Next(0, 10).ToString();
                }
            }

            return Arr;
        }
        static public void Task()
        {
        //            Дано целое число L(> 0) и последовательность
        //непустых строк A.Строки последовательности содержат
        //только цифры и заглавные буквы латинского алфавита. Из
        //элементов A, предшествующих первому элементу, длина которого превышает L, извлечь строки, оканчивающиеся буквой. Полученную последовательность отсортировать по убыванию длин строк, а строки одинаковой длины — в лексикографическом порядке по возрастанию.
            Console.WriteLine("Task 28");
            int L = 4;
            var A = GetEnumerableString(10);
            var B = A.TakeWhile(x => x.Length <= L).Where(x => char.IsLetter(x.Last())).OrderByDescending(x => x.Length).ThenBy(x => x).ToArray();
        }
    }
}
