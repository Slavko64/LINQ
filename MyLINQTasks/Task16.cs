﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task16
    {
        static public void Task()
        {
            Console.WriteLine("Task 16");
            var A = Program.GetEnumerableInt(10);
            var B = A.Where(x => x > 0).ToList();
        }
    }
}
