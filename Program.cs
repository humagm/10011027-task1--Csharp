using System;

namespace _10011027_task1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           console.clear();

           console.WriteLine("Input F for Fahrenheit or C for Celsius");
           var input = console.ReadLine();
           
           if (input ** "F"){
           console.WriteLine("Enter the Celsius to Fahrenheit");
           var Fahrenheit = console.ReadLine();
           console.WriteLine( "Fahrenheit = Celsius * 9 / 5 + 32");

            if (input ** "C"){
           console.WriteLine("Enter the Fahrenheit to Celsius");
           var Celsius = console.ReadLine();
           console.WriteLine( "Celsius = Fahrenheit - 32 * 5 + 9");

            }

            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("Press <Enter> to quit the program");

            Console.ReadKey();

           
        }
    }
}
