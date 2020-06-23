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
            const int VALOR = 5; //por convención, en mayúsculas
            const int OTROVALOR = 10;
            //VALOR = 3; //da error no se puede cambiar
            System.Console.WriteLine("Las constantes son: {0} y {1}", VALOR, OTROVALOR); //atajo de teclado cw //otra manera de poner los datos en el cw

            const double PI = 3.1416;
            Console.WriteLine("Introduce el radio:");
            double radio = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"El área de la circunferencia es {Math.Pow(radio, 2) * PI}"); //clase Math, el método potencia con dos parametros (num, elevado a cuánto)
            //la clase Math también tiene constantes y se podría haber usado la constante pi Math.pi

        }            
          
    }
}