﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Task46
    {
        //         Даны последовательности положительных целых
        //чисел A и B; все числа в каждой последовательности различны.Найти последовательность всех пар чисел, удовлетворяющих следующим условиям: первый элемент пары принадлежит последовательности A, второй принадлежит B, и
        //оба элемента оканчиваются одной и той же цифрой.Результирующая последовательность называется внутренним объединением последовательностей A и B по ключу, определяемому последними цифрами исходных чисел.Представить
        //найденное объединение в виде последовательности строк,
        //содержащих первый и второй элементы пары, разделенные
        //дефисом, например, «49-129». Порядок следования пар должен определяться исходным порядком элементов последовательности A, а для равных первых элементов — порядком
        //элементов последовательности B. 
        static public void Task()
        {
            Console.WriteLine("Task 46");
            var A = new[] { 1, 3, 15, 19,88,196,304,202,156};
            var B = new[] { 4, 8, 16, 13, 89, 169, 305, 201, 154 };
            var C = A.Join(B, x => x%10, y => y%10, (x, y) => x + "-" + y).ToArray();

        }
    }
}
