using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Program
    {
        static public string[] GetEnumerableStringWithLetters(int n)
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
        static public string[] GetEnumerableString(int n)
        {
            Random rand = new Random();
            string[] Arr = new string[n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < rand.Next(1,15); j++)
                    Arr[i] += rand.Next(0, 10).ToString();
                
            return Arr;
        }
        static public void Put(string element) => Console.WriteLine(element);
        static public void Put(int element) => Console.WriteLine(element);
        static public int[] GetEnumerableInt(int n)
        {
            Random rand = new Random();
            int[] Arr = new int[n];

            for (int i = 0; i < n; i++)
                Arr[i]  = rand.Next(-100, 100);

            return Arr;
        }
        static void Main(string[] args)
        {
            //Task1.Task();
            //Task2.Task();
            //Task3.Task();
            //Task4.Task();
            //Task5.Task();
            //Task6.Task();
            //Task7.Task();
            //Task8.Task();
            //Task9.Task();
            //Task10.Task();
            //Task11.Task();
            //Task12.Task();
            //Task13.Task();
            //Task14.Task();
            //Task15.Task();
            //Task16.Task();
            //Task17.Task();
            //Task18.Task();
            //Task19.Task();
            //Task20.Task();
            //Task21.Task();
            //Task22.Task();
            //Task23.Task();
            //Task24.Task();
            //Task25.Task();
            Task26.Task();
            Task27.Task();
            Task28.Task();
            Task29.Task();
            Task30.Task();
            Task31.Task();
            Console.ReadLine();
        }
    }
}
