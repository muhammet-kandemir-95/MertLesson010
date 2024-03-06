using System;
using System.Xml;

namespace MertLesson010
{
    class Program
    {
        public static int B(int input)
        {
            return Math.Abs(input);
        }

        public static int FormulaD(int input)
        {
            return (int)Math.Ceiling(Math.Sqrt(input)) / 2;
        }

        public static int[] A(int input)
        {
            // 1. Madde
            int n = (int)Math.Sqrt(input);
            int[] primeDivisors = new int[FormulaD(input) * 2];
            int c = 0;

            // 2. Madde
            for (int i = 2; i <= n; i++)
            {
                int mod = input % i;

                if (mod == 0)
                {
                    primeDivisors[c] = i;
                    c++;
                    primeDivisors[c] = input / i;
                    c++;
                }
            }

            // 2,5. Madde
            if (c == 0)
            {
                primeDivisors[0] = input;
            }

            // 3. Madde
            for (int i = 0; i < primeDivisors.Length; i++)
            {
                if (D(primeDivisors[i]) == false)
                {
                    primeDivisors[i] = 0;
                }
            }

            return primeDivisors.Where(o => o != 0).ToArray();
        }

        public static bool D(int input)
        {
            bool result = true;

            // 1. Madde
            int n = (int)Math.Sqrt(input);

            // 2. Madde
            for (int i = 2; i <= n; i++)
            {
                // 3. Madde
                if (input % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static string C(int[] input)
        {
            // 2. Madde
            int[] Ip = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                Ip[i] = B(input[i]);
            }
            // 3. Madde
            int max = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }

            int[,] D = new int[input.Length, FormulaD(max)];

            // 4. Madde


            // 5. Madde


        }

        public static void Main(string[] args)
        {
            int[] a = A(101042479);
            Console.WriteLine("Result: " + C(new int[] { 12, 15 }));
        }
    }
}