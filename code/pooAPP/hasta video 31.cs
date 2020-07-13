/*using System;

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
           otroCoche.setExtras(true, "Cuero");
           System.Console.WriteLine(otroCoche.getExtras());
        }
    }

    partial class Coche //con partial puedes partir las clases si son demasiado largas
    { //si una clase no tiene constructor, c# pone uno por defecto que se llame igual que la clase y está vacío, pero existe
        public Coche()
        {
            this.ruedas = 4;
            this.largo = 2300.5;
            this.ancho = 0.800;
            this.tapiceria = "Tela";
        }
         //con más de un constructor, sobrecarga de constructores. son igual pero con distinto numero de parámetros
         public Coche(double largoCoche, double anchoCoche)
        {
            this.ruedas = 4;
            this.largo = largoCoche;
            this.ancho = anchoCoche;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
// segunda parte de la clase
    partial class Coche
    {
        public String getInfo() => $"Información del coche,  ruedas: {this.ruedas}, larg: {this.largo} y ancho: {this.ancho}";

        public String getExtras() => $"Información de los extras, climatizador: {this.climatizador} y tapiceria: {this.tapiceria}";

        public void setExtras(bool paramClima, string paramTapi) {
            this.climatizador = paramClima;
            this.tapiceria = paramTapi;
        }

    }
}
*/