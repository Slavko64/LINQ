﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Program
    {
        static public string[] GetEnumerableStringWithLetters(int n, Random rand)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
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
        static public string[] GetEnumerableOnlyLetters(int n)
        {
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rand = new Random();
            string[] Arr = new string[n];
            int length;
            for (int i = 0; i < n; i++)
            {
                length = rand.Next(0, 6);
                for (int j = 0; j < length; j++)
                {
                     Arr[i] += Alphabet[rand.Next(0, 26)].ToString();
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
            //Task01.Task();
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
            //Task26.Task();
            //Task27.Task();
            //Task28.Task();
            //Task29.Task();
            //Task30.Task();
            //Task31.Task();
            //Task32.Task();
            //Task33.Task();
            //Task34.Task();
            //Task35.Task();
            //Task36.Task();
            //Task37.Task();
            //Task38.Task();
            //Task39.Task();
            //Task40.Task();
            //Task41.Task();
            //Task42.Task();
            //Task43.Task();
            //Task44.Task();
            //Task45.Task();
            //Task46.Task();
            //Task47.Task();
            //Task48.Task();
            //Task49.Task();
            //Task50.Task();
            //Task51.Task();
            //Task52.Task();
            Homework1.Homework01();
            Homework1.Homework02();
            Homework1.Homework03();
            Console.ReadLine();
        }
    }
}
