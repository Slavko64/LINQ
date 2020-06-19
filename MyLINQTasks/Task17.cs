using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task17
    {
        static public void Task()
        {
            Console.WriteLine("Task 17");
            var A = Program.GetEnumerableInt(100);
            var B = A.Where(x => x%2 != 0).Distinct().ToList();
        }
    }
}
