using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Fitness
{
    class Program
    {
        /* ИМТ = m/h² */
        static void Main(string[] args)
        {
            Console.WriteLine("Input your mass..");
            double mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your height...");
            double height = Convert.ToDouble(Console.ReadLine());
            
            double numeration;
            double height2 = Math.Pow(height, 2);

            numeration = mass/height2;
            Console.WriteLine("You KKD is = " + numeration);

            if ((numeration < 17.0 ) && (numeration > 16.0))
            {
                Console.WriteLine("Your KKD is not good, go to doctor");
            }
            else if ((numeration > 16.0) && (numeration < 18.0))
            {
                Console.WriteLine("Insufficient (deficiency) body weight");
            }
            else if((numeration > 18.5) && (numeration < 25.0))
            {
                Console.WriteLine("Good");
            }
            else if ((numeration > 25.0) && (numeration < 30.0))
            {
                Console.WriteLine("Almost Good");
            }
            else if((numeration > 30.0) && (numeration < 35.0))
            {
                Console.WriteLine("Not Good");
            }
            else if (numeration > 35.0)
            {
                Console.WriteLine("Go to doctor");
            }
            else
            {
                Console.WriteLine("Try to input your heigth    1,70    ");
            }

            Console.ReadKey();
    }


    }
}
