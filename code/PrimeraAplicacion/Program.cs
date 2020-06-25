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
            System.Console.WriteLine(Suma(1,2));
            System.Console.WriteLine(Suma(1,2,3));
            System.Console.WriteLine(Suma(1,2,3.2));
        }

        //sobrecarga de métodos, se puede sobrecargar, mismo nomrbe si cambia algo en los parametros, o numero o tipos
        static int Suma(int op1, int op2) => op1 + op2;
        static int Suma(int op1, int op2, int op3) => op1 + op2 + op3;
        static double Suma(int op1, int op2, double op3) => op1 + op2 + op3;
        /***********************************************/

        //ámbito
        static void primer() => System.Console.WriteLine(num1 + num2);
        static void segundo() => System.Console.WriteLine(num1 + num2);

        static int num1 = 5; //con ambito de clase lass variables son campos de clase y accesibles por todos los mçetodos de la clase da igual crearlos después
        static int num2 = 7;
    }
}