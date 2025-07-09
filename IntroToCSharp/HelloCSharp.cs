using System;
using System.Globalization;

namespace IntroToCSharp
{
    //prueba de comentario
    class HelloCSharp
    {
        public static DateTime Now { get; }

        static void Main(string[] args)

        {
            for (sbyte i = 1; i <= 32; i++)
            {
                if (i == 0)
                {
                    System.Console.WriteLine(i);
                }

                else
                {
                    if ((i % 2) != 0)
                    {
                        System.Console.WriteLine("-" + i);
                    }
                    else
                    {
                        System.Console.WriteLine(i);
                    }
                }
            }
            System.Console.WriteLine("Write your age");
            int ActualAge = Convert.ToInt32(System.Console.ReadLine());
            int FutureAge = ActualAge + 10;
            System.Console.WriteLine("Your age in 10 years it will be:" + FutureAge +"years");

            DateTime localDate = DateTime.Now;
            string name = "yeliana";
            string lastname = "mena";
            System.Console.WriteLine("1\n101\n1001");
            System.Console.WriteLine(name);
            System.Console.WriteLine(lastname);
            System.Console.WriteLine(localDate);
            System.Console.WriteLine(Math.Sqrt(12345));

        }
    }
}