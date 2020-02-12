using System;

namespace _12_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int resultado = 0 ;

            for (int tabuada = 1; tabuada <= 10; tabuada++)
            {

                for (int n1 = 0; n1 <= 10; n1++)
                {
                    Console.WriteLine(n1 + "x" + tabuada + "=" + n1*tabuada);
                    
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
