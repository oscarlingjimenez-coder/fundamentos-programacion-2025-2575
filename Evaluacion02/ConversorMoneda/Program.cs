namespace ConversorMoneda;

class Program
{
    static void Main(string[] args)
    {
        // Declarar la tasa de cambio del dólar
        const double TASA_USD = 60.0;
        // Declarar las variables
        double montoPesos;
        double montoDolares;
        // Solicitar el monto en pesos dominicanos
Console.Write("Ingrese el monto en pesos dominicanos: ");
montoPesos = double.Parse(Console.ReadLine() ?? "", System.Globalization.CultureInfo.InvariantCulture);
// Convertir pesos dominicanos a dólares
montoDolares = montoPesos / TASA_USD;
// Mostrar el resultado de la conversión
Console.WriteLine("\n--- CONVERSOR DE MONEDA ---");
Console.WriteLine($"Monto en pesos: RD${montoPesos:F2}");
Console.WriteLine($"Tasa de cambio: RD${TASA_USD:F2}");
Console.WriteLine($"Equivalente en dólares: US${montoDolares:F2}");

    }
}
