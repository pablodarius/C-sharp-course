using System;

namespace pooAPP
{
    class Program
    {
        static void Main(string[] args)
        {
           Coche unCoche = new Coche();
           Coche otroCoche = new Coche(2000, 1000);
           System.Console.WriteLine(unCoche.getInfo());
           System.Console.WriteLine(otroCoche.getInfo());
        }
    }

    class Coche
    { //si una clase no tiene constructor, c# pone uno por defecto que se llame igual que la clase y está vacío, pero existe
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
         //con más de un constructor, sobrecarga de constructores. son igual pero con distinto numero de parámetros
         public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public String getInfo() => $"Información del coche ruedas: {ruedas}, larg: {largo} y ancho: {ancho}";

    }
}
