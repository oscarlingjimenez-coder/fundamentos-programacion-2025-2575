namespace AdivinaNumero;

class Program
{
    static void Main(string[] args)
    {
       // Generar un número aleatorio entre 1 y 100
int numeroSecreto = Random.Shared.Next(1, 101);

// Variable para almacenar el número del usuario
int numeroUsuario;

// Contador de intentos
int intentos = 0;


// Mostrar mensaje de bienvenida
Console.WriteLine("===== ADIVINA EL NUMERO =====");
Console.WriteLine("Estoy pensando en un numero entre 1 y 100.");

// Repetir hasta adivinar el número secreto
do
{
    Console.Write("Introduce un numero entre 1 y 100: ");
    string entrada = Console.ReadLine() ?? "";

    // Validar que sea un número entero entre 1 y 100
    if (!int.TryParse(entrada, out numeroUsuario) ||
        numeroUsuario < 1 || numeroUsuario > 100)
    {
        Console.WriteLine("Error: introduce un numero valido entre 1 y 100.");
        numeroUsuario = 0;
        continue;
    }

    // Contar los intentos válidos
    intentos++;

    // Comparar el número introducido con el número secreto
if (numeroUsuario < numeroSecreto)
{
    Console.WriteLine("El número secreto es MAYOR. Intenta nuevamente.");
}
else if (numeroUsuario > numeroSecreto)
{
    Console.WriteLine("El número secreto es MENOR. Intenta nuevamente.");
}

} while (numeroUsuario != numeroSecreto);

// Mostrar el resultado cuando el usuario adivine
Console.WriteLine("\n===== FELICIDADES =====");

Console.WriteLine($"Has adivinado el número secreto: {numeroSecreto}");

Console.WriteLine($"Cantidad de intentos: {intentos}");

Console.WriteLine("=======================");
    }
}
