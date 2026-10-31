namespace FichaPersonal;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        bool trabaja;
        // Solicitar el nombre del usuario
Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine() ?? ""; 
// Solicitar la edad del usuario
Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine() ?? "");
// Solicitar la estatura del usuario
Console.Write("Ingrese su estatura en metros: ");
estatura = double.Parse(Console.ReadLine() ?? "", System.Globalization.CultureInfo.InvariantCulture);
// Solicitar si el usuario trabaja
Console.Write("¿Trabaja actualmente? (true/false): ");
trabaja = bool.Parse(Console.ReadLine() ?? "");
// Calcular el año en que cumplirá 30 años
const int anioActual = 2026;
int anioCumple30 = anioActual + (30 - edad);
// Mostrar la ficha personal del usuario
Console.WriteLine("\n--- FICHA PERSONAL ---");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Estatura: {estatura} metros");
Console.WriteLine($"¿Trabaja actualmente?: {trabaja}");
Console.WriteLine($"Año en que cumplirá 30 años: {anioCumple30}");


    }
}
