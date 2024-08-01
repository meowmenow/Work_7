using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адовые_коды__14__Практическая_намбер_фортин__v2._0
{
    class Program
    {
        static void SumRange(int A, int B, int C, out int sum, out int range)
        {
            sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            range = 0;
            for (int k = B; k <= C; k++)
            {
                range += k;
            }
        }
        static void Main(string[] args)
        {
            int z1, z2, z3;
            int sum;
            int x;
            Console.WriteLine("Введите целые числа A, B, C");
            z1 = Convert.ToInt32(Console.ReadLine());
            z2 = Convert.ToInt32(Console.ReadLine());
            z3 = Convert.ToInt32(Console.ReadLine());
            SumRange(z1, z2, z3, out sum, out x);
            if (z1 > z2)
            {
                sum = 0;
            }
            Console.WriteLine("Сумма целых чисел A, B= " + sum);
            Console.WriteLine("Сумма целых чисел B, C= " + x);
            Console.ReadKey();

        }
    }
}   
