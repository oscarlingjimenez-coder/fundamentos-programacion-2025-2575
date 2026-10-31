namespace Casting;

class Program
{
    static void Main(string[] args)
    {
        // declarar las variables
        double numeroDecimal;
        int numeroEntero;
        double numeroConvertido;
        // solicitar un numero decimal al usuario
        Console.Write("Ingrese un número decimal: ");
numeroDecimal = double.Parse(Console.ReadLine() ?? "", System.Globalization.CultureInfo.InvariantCulture);
// Convertir el número decimal a entero (casting explícito)
numeroEntero = (int)numeroDecimal;
// Convertir un entero a decimal (casting implícito)
numeroConvertido = numeroEntero;
// Mostrar los resultados de las conversiones
Console.WriteLine("\n--- RESULTADOS DEL CASTING ---");
Console.WriteLine($"Número original: {numeroDecimal}");
Console.WriteLine($"Casting explícito (double a int): {numeroEntero}");
Console.WriteLine($"Casting implícito (int a double): {numeroConvertido}");


    }
}
