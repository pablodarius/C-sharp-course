/*using System;

namespace pooAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // Variable/objeto de tipo circulo
            miCirculo = new Circulo(); // iniciacion de variable/objeto de tipo circulo. Instanciacion = ejemplarizacion = creacion de ejemplar de clase
            System.Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();
            System.Console.WriteLine(miCirculo.CalculoArea(8));

            ConversorEuroDollar miConversor = new ConversorEuroDollar();
            System.Console.WriteLine(miConversor.convierte(50));
            miConversor.setEuro(1.45);
            System.Console.WriteLine(miConversor.convierte(50));
        }
    }

     class Circulo
    {
        private const double pi = 3.1416; //propiedad o campo de clase, constante, si no ponemos private, es private por defecto pero por convención se pone

        public double CalculoArea(int radio) { // metodo de clase
            return pi * radio * radio;
        }

    }

    class ConversorEuroDollar
    {
        private double euro = 1.253;

        public double convierte(double cantidad) => cantidad * euro;

        public void setEuro(double valor) {
            if (valor >= 0) {
                euro = valor;
            } 
        }
    }
}
*/
