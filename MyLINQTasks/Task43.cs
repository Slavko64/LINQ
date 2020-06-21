using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task43
    {
        //        Дано целое число K(> 0) и последовательность
        //непустых строк A.Получить последовательность символов,
        //которая определяется следующим образом: для первых K
        //элементов последовательности A в новую последовательность заносятся символы, стоящие на нечетных позициях
        //            данной строки(1, 3, …), а для остальных элементов A —
        //символы на четных позициях(2, 4, …). В полученной последовательности поменять порядок элементов на обратный.
        static public string[] GetEnumerableOnlyLetters(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var FullAlphabet = Alphabet.Select(x => x.ToString()).Concat(Alphabet.Select(x => x.ToString().ToLower())).Reverse().ToArray();
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
            Console.WriteLine("Task 43");
            int K = 5;
            var A = GetEnumerableOnlyLetters(50);
            var B = A.Take(K).Select(x => x.Where((y, index) => (index + 1) % 2 != 0).Select(y => y).ToArray()).Concat(A.Skip(K).Select(x => x.Where((y, index) => (index + 1) % 2 == 0).Select(y => y).ToArray())).ToArray();

        }
    }
}
