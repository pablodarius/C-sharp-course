using System;

namespace pooAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea() {
            // TODO:
            // para seguir por aqui mañana, visual studio lo entiende también y te los enseña en el panel de soluciones
            Punto origen = new Punto();
            Punto destino = new Punto(1,1);
            double distancia = origen.DistanciaHasta(destino);
            System.Console.WriteLine(distancia);
        }   
    }    
}
