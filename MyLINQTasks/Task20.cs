﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task20
    {
        static public void Task()
        {
            Console.WriteLine("Task 20");
            var A = Program.GetEnumerableInt(100);
            var B = A.OrderBy(x => x % 100 == 0 && x % 10 != 0);

        }
    }
}
