using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave1();
            opgave2();
            opgave3();
            opgave4();
        }

        private static void opgave4()
        {
            Random random = new Random();
            int[] tal = new int[5];
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = random.Next(1000);

                Console.WriteLine(tal[i]);
            }

            int biggestNumber = Int32.MinValue;

            for (int i = 0; i < tal.Length; i++)
            {
                if (biggestNumber < tal[i])
                {
                    biggestNumber = tal[i];
                }
            }

            Console.WriteLine("\n" + biggestNumber);
        }

        private static void opgave3()
        {
            List<int> fibo = new List<int>();
            fibo.Add(0);
            fibo.Add(1);
            for (int i = 2; i < 50; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(fibo[i]);
            }
        }

        private static void opgave2()
        {
            String s = "racecar!";
            char[] c = s.ToCharArray();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(c[i]);
            }
        }

        private static void opgave1()
        {
            Random random = new Random();
            List<int> tal = new List<int>();
            for (int i = 0; i < tal.Count; i++)
            {
                tal.Add(random.Next(1000));
            }

            for (int i = 0; i < tal.Count; i++)
            {
                Console.Write(tal[i] + ", ");
            }

            Console.WriteLine("\nbaglæns\n");
            //Console.WriteLine(String.Join(tal.Reverse()));
        }
    }
}