using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task19
    {
        static public void Task()
        {
            Console.WriteLine("Task 19");
            int D = 8;
            var A = Program.GetEnumerableInt(100);
            var B = A.Where(x => x.ToString().Last() == D.ToString().First()).Reverse().Distinct().Reverse().ToList();
        }
    }
}
