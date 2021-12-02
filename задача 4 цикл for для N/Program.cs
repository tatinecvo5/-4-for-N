using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_4_цикл_for_для_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (; N > 0; --N)
            {
                //если раскрыть скобки и все посокращать получится NxN=N*N, может не так понял задачу
                int NxN = 1 + (N - 2) * N + (2 * N - 1);
                Console.WriteLine(NxN);
            }
            Console.ReadKey();
        }
    }
}
