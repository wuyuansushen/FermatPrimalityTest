using System;
using System.Numerics;

namespace FermatPrimalitySet
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_max = 0, max_tests = 0;
            Console.Write("Max-limit number: ");
            num_max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max prime test: ");
            max_tests = Convert.ToInt32(Console.ReadLine());


            Random r1 = new Random();
            int ranNum;
            do
            {
                ranNum = r1.Next(1, num_max);
            } while (!IsPrime(ranNum, max_tests));
            Console.Write($"output: {ranNum}");
        }

        static bool IsPrime(int ran, int max_test)
        {
            Random r2 = new Random();
            int r = 0;
            for (int i = 0; i < max_test; i++)
            {
                r = r2.Next(1, ran);
                if (BigExponent(r, ran - 1) % ran != 1)
                    return false;
            }
            return true;
        }

        static BigInteger BigExponent(BigInteger baseNum, BigInteger exponent)
        {
            BigInteger evenresult = 1;
            BigInteger oddResult = baseNum;
            while (exponent != 0)
            {
                if ((exponent & 1) == 1)
                    evenresult *= oddResult;//Collect rest odd exponent
                else
                { }
                oddResult *= oddResult;
                exponent = exponent >> 1;
            }
            return evenresult;
        }
    }
}