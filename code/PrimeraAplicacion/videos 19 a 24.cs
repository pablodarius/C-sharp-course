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
            System.Console.WriteLine($"Yaaaaaaaaaaaaassssssss, well done! the number was {n}");

            // Adivina un número del 0 al 100 en mayor-menor 
            Random number = new Random();
            int n = number.Next(0, 100);
            int attempts = 0;
            int userNum = 0;
            do {
                System.Console.WriteLine("Guess the Number...");

                try {
                    userNum = Int32.Parse(Console.ReadLine());
                    attempts++;
                    if (userNum > n) System.Console.WriteLine("Less please, try again...");
                    if (userNum < n) System.Console.WriteLine("More please, try again...");
                /*} catch(FormatException ex) { // se pueden poner ANTES de la general, los catch concretos que queramos tratar de manera especial
                    System.Console.WriteLine("No has introducido un valor numérico válido");
                } catch(OverflowException ex) { 
                    System.Console.WriteLine("Has introducido un valor demasiado grande"); 
                } catch (Exception ex) { // para recoger la general exception, podría solo ponerse catch {}, pero es mala practica
                    System.Console.WriteLine("No has introducido un valor válido: " + ex.Message);
                }
                // para excepcionies con filtro si queremos un tratamiento especial a un, se pone la general con el when
                } catch (Exception ex) when (ex.GetType() != typeof(FormatException)) { //catch para todas menos la FormatException
                    System.Console.WriteLine("No has introducido un valor válido: " + ex.Message);
                } catch (FormatException ex) {
                    System.Console.WriteLine("No has introducido un valor numérico válido");
                }
            } while (n != userNum);
            System.Console.WriteLine($"Yaaaaaaaaaaaaassssssss, well done! the number was {n} and you have needed {attempts} attemps");
            System.Console.WriteLine("A partir de esta línea de código el programa continuaría");

            checked { //sin esto, el desbordamiento aritmetico, el compilador lo maneja y devuelve un valor negativo grande como valor erroneo, solo para INT y LONG
                int num = int.MaxValue;
                num += 20; // int resultado = unchecked(numero += 20); para que justo esa línea no vaya checkeada en este bloque checked
                System.Console.WriteLine(num);
            } //se puede poner en el IDE que el checked esta activado sin ponerlo nosotros para todo lo aritmetico
            //se puede hacer de forma abreviada sobre la línea que necesita el checked
            int numero = int.MaxValue;
            int resultado = checked(numero += 20);
        }        
    }
}*/