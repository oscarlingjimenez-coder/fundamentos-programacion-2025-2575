namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        const int ANIO_ACTUAL = 2026;
        Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine() ?? "";
Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine() ?? "");
Console.Write("Ingrese su estatura en metros: ");
estatura = double.Parse(Console.ReadLine() ?? "", System.Globalization.CultureInfo.InvariantCulture);
int anioNacimiento = ANIO_ACTUAL - edad;
Console.WriteLine("\n--- INFORMACIÓN PERSONAL ---");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Estatura: {estatura} metros");
Console.WriteLine($"Año de nacimiento aproximado: {anioNacimiento}");
    }
}
