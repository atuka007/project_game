using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 1;
            int c = 2;
            int d = 4;
            int q = 3;
            int[] arr = { a, b, c, d, q};
            int pos, tmp = 0;
            
            for (int i = 0; i < 5; ++i)
            {
                pos = i;
                tmp = arr[i];
                for (int j = i + 1; j < 5; ++j)
                {
                    if (arr[j] <  tmp)
                    {
                        pos = j;
                        tmp = arr[j];
                    }
                }
                arr[pos] = arr[i];
                arr[i] = tmp;
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
