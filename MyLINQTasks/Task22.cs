﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task22
    {
//        Дано целое число K(> 0) и строковая последовательность A.Строки последовательности содержат только
//цифры и заглавные буквы латинского алфавита.Извлечь из A
//все строки длины K, оканчивающиеся цифрой, отсортировав
//их в лексикографическом порядке по возрастанию.
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
            Console.WriteLine("Task 22");
            int K = 4;
            var A = GetEnumerableString(100);
            var B = A.Where(x => x.Length == K && char.IsDigit(x.Last()) == true ).OrderBy(x => x).ToList();

        }
    }
}
