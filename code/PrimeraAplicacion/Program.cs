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
            System.IO.StreamReader archivo = null;

            System.Console.WriteLine("Introduce número de mes: ");
            int numMes = int.Parse(Console.ReadLine());
            try {
                System.Console.WriteLine(NombreDelMes(numMes));
            } catch (Exception e) {
                System.Console.WriteLine($"Excepción lanzada {e}");
            }           
            
            System.Console.WriteLine("Aquí continua el programa .......");

            try {
                string linea;
                int contador = 0;           
                string path = @"D:\Cursos\Curso c sharp\mes.txt";
                archivo = new System.IO.StreamReader(path);
                while ((linea = archivo.ReadLine()) != null) {
                    System.Console.WriteLine(linea);
                    contador++;
                }
            } catch(Exception e) {
                System.Console.WriteLine($"Error al leer: {e}");
            } finally {
                if (archivo != null) {
                    archivo.Close();
                    System.Console.WriteLine("Conexión cerrada!");
                }
            }
        }

        public static string NombreDelMes(int mes) {
            switch (mes) {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException(); //toda la info en la bliblioteca de clases .net framework library en google
            }
        }
            
    }
}