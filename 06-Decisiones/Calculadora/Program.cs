using System;
using System.Globalization;


namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        // Declarar las variables
            double numero1, numero2, resultado;
            int opcion;

            // Solicitar el primer número
            Console.Write("Ingrese el primer número: ");
            numero1 = double.Parse(
                Console.ReadLine() ?? "",
                CultureInfo.InvariantCulture
            );

            // Solicitar el segundo número
            Console.Write("Ingrese el segundo número: ");
            numero2 = double.Parse(
                Console.ReadLine() ?? "",
                CultureInfo.InvariantCulture
            );

            // Mostrar el menú de operaciones
            Console.WriteLine("\n===== CALCULADORA =====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            // Solicitar la opción
            Console.Write("Seleccione una opción (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Error: debe ingresar una opción válida.");
                return;
            }

            // Ejecutar la operación seleccionada
            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado de la suma: {resultado:N2}");
                    break;

                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado de la resta: {resultado:N2}");
                    break;

                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado de la multiplicación: {resultado:N2}");
                    break;

                case 4:
                    // Evitar la división entre cero
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado de la división: {resultado:N2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: opción no válida.");
                    break;
            }
        }
    }
        
