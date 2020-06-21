using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task42
    {
        //        Дана последовательность непустых строк.Получить последовательность символов, которая определяется
        //следующим образом: для строк с нечетными порядковыми
        //номерами (1, 3, …) в последовательность символов включаются все прописные латинские буквы, содержащиеся в этих
        //строках, а для строк с четными номерами(2, 4, …) — все их
        //строчные латинские буквы.В полученной последовательности символов сохранить их исходный порядок следования.
        static public string[] GetEnumerableOnlyLetters(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var FullAlphabet = Alphabet.Select(x=>x.ToString()).Union(Alphabet.Select(x => x.ToString().ToLower())).ToArray();
            Random rand = new Random();
            string[] Arr = new string[n];
            int length;
            for (int i = 0; i < n; i++)
            {
                length = rand.Next(1, 6);
                for (int j = 0; j < length; j++)
                {
                    Arr[i] += FullAlphabet[rand.Next(0, 52)];
                }
            }
            return Arr;
        }
        static public void Task()
        {
            Console.WriteLine("Task 42");
            var A = GetEnumerableOnlyLetters(50);
            var B = A.SelectMany((x, index) => {
                if ((index + 1) % 2 != 0)
                    return new[] { x.Where(y => char.IsUpper(y)).Select(y => y).ToArray() };
                else
                    return new[] { x.Where(y => char.IsLower(y)).Select(y => y).ToArray() };
            }).ToArray();

        }
    }
}
