namespace Ciclos;

class Program
{
    static void Main(string[] args)
    {
        // Declarar las variables
int numero;
int contador = 1;
int resultado;
int suma = 0;

// Solicitar y validar un número entre 1 y 12
do
{
    Console.Write("Ingrese un número entre 1 y 12: ");
    string entrada = Console.ReadLine() ?? "";

    if (!int.TryParse(entrada, out numero) || numero < 1 || numero > 12)
    {
        Console.WriteLine("Error: debe ingresar un número entre 1 y 12.");
    }

} while (numero < 1 || numero > 12);

// Mostrar el encabezado de la tabla
Console.WriteLine($"\n===== TABLA DEL {numero} =====");

// Mostrar la tabla de multiplicar del 1 al 12
while (contador <= 12)
{
    resultado = numero * contador;

    Console.WriteLine($"{numero} x {contador} = {resultado}");



    // Acumular los resultados de las multiplicaciones
suma = suma + resultado;

    contador++;
}


// Mostrar la tabla de multiplicar del 1 al 12
while (contador <= 12)
{
    resultado = numero * contador;

    Console.WriteLine($"{numero} x {contador} = {resultado}");

    // Acumular los resultados
    suma = suma + resultado;

    contador++;
}

// Mostrar la suma al finalizar todas las multiplicaciones
Console.WriteLine("-------------------------");
Console.WriteLine($"Suma total de los resultados: {suma}");
}
    }
