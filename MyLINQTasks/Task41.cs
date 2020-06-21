using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task41
    {
        //        Дано целое число K(> 0) и строковая последовательность A.Каждый элемент последовательности представляет собой несколько слов из заглавных латинских букв, разделенных символами «.» (точка). Получить последовательность строк, содержащую все слова длины K из элементов A
        //в лексикографическом порядке по возрастанию (слова могут
        //повторяться). 
        static public string[] GetEnumerableStringWithWords(int n)
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
                    Arr[i] += Alphabet[rand.Next(0, 26)].ToString();
                    if (rand.Next(1, 5) == 1)
                        Arr[i] += ".";
                }
            }
            return Arr;
        }
        static public void Task()
        {
            Console.WriteLine("Task 41");
            int K = 4;
            var A = GetEnumerableStringWithWords(50);
            var B = A.SelectMany(x => x.Split('.').Where(y=>y.Length == K)).ToArray();

        }
    }
}
