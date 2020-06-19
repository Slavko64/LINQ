using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task24
    {
        //        Дано целое число K(> 0) и строковая последовательность A.Из элементов A, предшествующих элементу с
        //порядковым номером K, извлечь те строки, которые имеют
        //нечетную длину и начинаются с заглавной латинской буквы,
        //изменив порядок следования извлеченных строк на обратный.
        static public string[] GetEnumerableString(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rand = new Random();
            string[] Arr = new string[n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < rand.Next(1, 15); j++)
                {
                    if (rand.Next(1, 3) == 1)
                        Arr[i] += Alphabet[rand.Next(0, 26)].ToString();
                    else
                        Arr[i] += rand.Next(0, 10).ToString();
                }


            return Arr;
        }
        static public void Task()
        {
            Console.WriteLine("Task 24");
            int K = 20;
            var A = GetEnumerableString(100);
            var B = A.Take(K).Where(X => X.Length % 2 != 0 && char.IsUpper(X.First()) == true).Reverse().ToArray();

        }
    }
}
