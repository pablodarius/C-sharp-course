using System;

namespace pooAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // Variable/objeto de tipo circulo
            miCirculo = new Circulo(); // iniciacion de variable/objeto de tipo circulo. Instanciacion = ejemplarizacion = creacion de ejemplar de clase
            System.Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();
            System.Console.WriteLine(miCirculo.calculoArea(8));
        }
    }

     class Circulo
    {
        const double pi = 3.1416; //propiedad o campo de clase, constante

        public double calculoArea(int radio) { // metodo de clase
            return pi * radio * radio;
        }

    }
}
