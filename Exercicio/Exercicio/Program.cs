using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            float divisor = 0;
            float dividendo =0;
            float resultado = 0;

         for(;;){
            Console.WriteLine("Informe o dividendo: ");
            dividendo =float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o divisor: ");
            divisor =float.Parse(Console.ReadLine());

            if(divisor == 0){
                Console.WriteLine("Divisão impossivel!");
                Console.WriteLine();
                
            }
            else{
                resultado = dividendo/divisor;
                Console.WriteLine();
                Console.WriteLine($"O resultado da divisão e: {resultado}");
                break;

            }
        }

        }
    }
}
