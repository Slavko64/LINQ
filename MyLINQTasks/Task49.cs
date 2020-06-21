using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task49
    {
        //        Даны строковые последовательности A, B и С;
        //        все строки в каждой последовательности различны, имеют ненулевую длину и содержат только цифры и заглавные буквы латинского алфавита.Найти внутреннее объединение A, B
        //и С (см.LinqBegin46), каждая тройка которого должна содержать строки, начинающиеся с одного и того же символа.
        //Представить найденное объединение в виде последовательности строк вида «EA= EB = EC», где EA, EB, EC — элементы из A,
        //B, C соответственно. Для различных элементов EA сохраняется исходный порядок их следования, для равных элементов
        //EA порядок троек определяется лексикографическим порядком элементов EB (по возрастанию), а для равных элементов
        //EA и EB — лексикографическим порядком элементов EC (по
        //убыванию).

        static public void Task()
        {
            Console.WriteLine("Task 49");
            Random rand = new Random();
            var A = Program.GetEnumerableStringWithLetters(100,rand);
            var B = Program.GetEnumerableStringWithLetters(100, rand);
            var C = Program.GetEnumerableStringWithLetters(100, rand);
            var D = A.Join(B.OrderBy(x=>x).Join(C.OrderByDescending(x=>x), x => x.First(), y => y.First(), (x, y) => x + "=" + y), x => x.First(), y => y.First(), (x, y) => x + "=" + y).ToArray();

        }
    }
}
