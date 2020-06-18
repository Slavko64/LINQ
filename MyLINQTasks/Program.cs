﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Program
    {
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
            Task1.Task();
            Task2.Task();
            Task3.Task();
            Task4.Task();
            Task5.Task();
            Console.ReadLine();
        }
    }
}