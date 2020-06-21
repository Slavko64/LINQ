using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task48
    {
        //        . Даны строковые последовательности A и B; все
        //строки в каждой последовательности различны, имеют ненулевую длину и содержат только цифры и заглавные буквы
        //латинского алфавита.Найти внутреннее объединение A и B
        //(см.LinqBegin46), каждая пара которого должна содержать
        //строки одинаковой длины.Представить найденное объединение в виде последовательности строк, содержащих первый
        //и второй элементы пары, разделенные двоеточием, например, «AB:CD». Порядок следования пар должен определяться лексикографическим порядком первых элементов пар (по
        //возрастанию), а для равных первых элементов — лексикографическим порядком вторых элементов пар (по убыванию). 
        static public void Task()
        {
            Console.WriteLine("Task 48");
            Random rand = new Random();
            var A = Program.GetEnumerableStringWithLetters(20, rand);
            var B = Program.GetEnumerableStringWithLetters(25, rand);
            var C = A.Where(x => x.Length >1).OrderBy(x =>x).Join(B.OrderByDescending(x => x), x => x.Length, y => y.Length, (x, y) => "" + x[0] + x[1] + ":" + y[0] + y[1]).ToArray();

        }
    }
}
