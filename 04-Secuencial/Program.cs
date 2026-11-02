namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
       // Contantes para convertir libras a kilogramos
        const double LIBRAS_A_KG = 0.453592;

        // Variables para el peso 
         double pesoLibras;
         double pesoKilogramos;

        // Variable para la temperatura
        double temperaturaFahrenheit;
        double temperaturaCelsius;

        // solicitar el numero de peso en libras al usuario
        Console.Write("Ingrese el peso en libras: ");
       pesoLibras = double.Parse(
Console.ReadLine() ?? "",
System.Globalization.CultureInfo.InvariantCulture
       );

            // Convertir el peso de libras a kilogramos
            pesoKilogramos = pesoLibras * LIBRAS_A_KG;

            // Agregar la temperatura en grados Fahrenheit
            Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
            temperaturaFahrenheit = double.Parse(
                Console.ReadLine() ?? "",
                System.Globalization.CultureInfo.InvariantCulture
                );

                // Convertir la temperatura de Fahrenheit a Celsius
                temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

                // Mostrar los resultados de las conersiones 
                Console.WriteLine("\n--- RESULTADOS DE LAS CONVERSIONES ---");

Console.WriteLine($"{pesoLibras:F2} libras equivalen a {pesoKilogramos:F2} kilogramos.");

Console.WriteLine($"{temperaturaFahrenheit:F2} °F equivalen a {temperaturaCelsius:F2} °C.");

    }
}