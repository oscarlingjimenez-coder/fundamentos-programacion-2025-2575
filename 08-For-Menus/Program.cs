namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
   
// Variable para almacenar la opción del usuario
int opcion;

// Repetir el menú hasta seleccionar 0
do
{
    Console.WriteLine("\n===== MENU PRINCIPAL =====");
    Console.WriteLine("1. Tablas de multiplicar");
    Console.WriteLine("2. Triangulo de asteriscos");
    Console.WriteLine("0. Salir");

    Console.Write("\nSeleccione una opcion: ");

    // Validar la entrada
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Error: ingrese una opcion numerica.");
        opcion = -1;
        continue;
    }

    // Ejecutar la opción seleccionada
    switch (opcion)
    {
        case 1:
            Console.WriteLine("\n===== TABLAS DE MULTIPLICAR =====");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int resultado = i * j;
                    Console.Write($"{resultado,4}");
                }

                Console.WriteLine();
            }
            break;

        case 2:
            Console.WriteLine("\n===== TRIANGULO DE ASTERISCOS =====");

            int filas;

            do
            {
                Console.Write("Ingrese la cantidad de filas: ");
                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out filas) || filas <= 0)
                {
                    Console.WriteLine("Error: ingrese un numero entero mayor que cero.");
                }

            } while (filas <= 0);

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            break;

        case 0:
            Console.WriteLine("\nSaliendo del programa...");
            break;

        default:
            Console.WriteLine("Error: seleccione una opcion valida.");
            break;
    }

} while (opcion != 0);


    }
}
