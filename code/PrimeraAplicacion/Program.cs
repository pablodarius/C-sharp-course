using System;
/*
Primer ejemplo de hola mundo
empezamos!!!
*/
namespace PrimeraAplicacion
{
    class Program
    { 
        static void Main(string[] args)
        {
            /*System.Console.WriteLine("¿Damos vueltas?");
            string respuesta = Console.ReadLine();
            while (respuesta != "no") {
                System.Console.WriteLine("vueltas...");
                System.Console.WriteLine("Te llamabas...");
                string nombre = Console.ReadLine();
                System.Console.WriteLine($"Oye {nombre}, Saldrás del bucle cuando me digas no...");
                System.Console.WriteLine("¿Seguimos?");
                respuesta = Console.ReadLine();
            }
            System.Console.WriteLine("Acabamos!!!");

            // Adivina un número del 0 al 100 en mayor-menor 
            Random number = new Random();
            int n = number.Next(0, 100);

            System.Console.WriteLine("Guess the Number...");
            int userNum = Int32.Parse(Console.ReadLine());
            while (n != userNum) {
                System.Console.WriteLine("Wrong!");
                if (userNum > n) {
                    System.Console.WriteLine("Less please, try again...");
                } else {
                    System.Console.WriteLine("More please, try again...");
                }

                System.Console.WriteLine("Guess the Number...");
                userNum = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine($"Yaaaaaaaaaaaaassssssss, well done! the number was {n}");*/

            // Adivina un número del 0 al 100 en mayor-menor 
            Random number = new Random();
            int n = number.Next(0, 100);
            int attempts = 0;
            int userNum;
            do {
                System.Console.WriteLine("Guess the Number...");
                userNum = Int32.Parse(Console.ReadLine());
                attempts++;

                if (userNum > n) System.Console.WriteLine("Less please, try again...");
                if (userNum < n) System.Console.WriteLine("More please, try again...");
            } while (n != userNum);
            System.Console.WriteLine($"Yaaaaaaaaaaaaassssssss, well done! the number was {n} and you have needed {attempts} attemps");
        }        
    }
}