using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task11
    {
        //Дана последовательность непустых строк.Используя метод Aggregate, получить строку, состоящую из начальных символов всех строк исходной последовательности. 
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
            Console.WriteLine("Task 11");
            var A = GetEnumerableString(10);
            string str =  "" + A.First().First();
            str = A.Aggregate((x, y) => str +=  "" + y.First());
            Program.Put(str);
        }
    }
}
