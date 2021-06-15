using System;
using System.Linq;

namespace DubugGit
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");

            int x = 5;
            int y = 6;

            int result = GetSum(x, y);
            int result2 = GetSum2(x, y);


            int[] numbers = Enumerable.Range(1, 10000000).ToArray();

            int result3 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result3 = i * i;
                Console.WriteLine(result3);
            }


            Console.WriteLine("Hej");

        }

        private static int GetSum2(int x, int y)
        {
            return x + y;
        }

        private static int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
