using System;
/*
Primer ejemplo de hola mundo
empezamos!!!

namespace PrimeraAplicacion
{
    class Program
    { 
        static void Main(string[] args)
        {
            System.Console.WriteLine(Suma(1,2));
            System.Console.WriteLine(Suma(1,2,3));
            System.Console.WriteLine(Suma(1,2,3.2));

            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            System.Console.WriteLine(SumaOp(valor1, valor2));
            System.Console.WriteLine(SumaOp(valor1, valor2, valor3));
        }

        //sobrecarga de métodos, se puede sobrecargar, mismo nomrbe si cambia algo en los parametros, o numero o tipos
        static int Suma(int op1, int op2) => op1 + op2;
        static int Suma(int op1, int op2, int op3) => op1 + op2 + op3;
        static double Suma(int op1, int op2, double op3) => op1 + op2 + op3;
        /***********************************************

        //ámbito
        static void primer() => System.Console.WriteLine(num1 + num2);
        static void segundo() => System.Console.WriteLine(num1 + num2);

        static int num1 = 5; //con ambito de clase lass variables son campos de clase y accesibles por todos los mçetodos de la clase da igual crearlos después
        static int num2 = 7;

        // parámetros opcionales, los opcionales deben ir a continuación de los obligatorios
        private static double SumaOp(int num1, double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }

        // si sobrecargo sin opcional, llamando con 2 parametros, esta ambigüedad se resuelve llamando al método que mas se adapte al num de parametros, o sea este segundo
        static double SumaOp(int num1, double num2)
        {
            return num1 + num2;
        }
    }
}*/