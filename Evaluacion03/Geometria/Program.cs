namespace Geometria;

class Program
{
    static void Main(string[] args)
    {
       // Datos del círculo
double radio;

// Datos del triángulo rectángulo
double baseTriangulo;
double alturaTriangulo;

// Resultados del círculo
double areaCirculo;
double circunferencia;

// Resultados del triángulo
double areaTriangulo;
double hipotenusa;

// Solicitar el radio del círculo
Console.Write("Ingrese el radio del círculo: ");
radio = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture
);

// Solicitar la base del triángulo
Console.Write("Ingrese la base del triángulo: ");
baseTriangulo = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture
);

// Solicitar la altura del triángulo
Console.Write("Ingrese la altura del triángulo: ");
alturaTriangulo = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture
);

// Calcular el área del círculo
areaCirculo = Math.PI * Math.Pow(radio, 2);

// Calcular la circunferencia del círculo
circunferencia = 2 * Math.PI * radio;

// Calcular el área del triángulo rectángulo
areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

// Calcular la hipotenusa utilizando el teorema de Pitágoras
hipotenusa = Math.Sqrt(
    Math.Pow(baseTriangulo, 2) +
    Math.Pow(alturaTriangulo, 2)
);

// Mostrar los resultados del círculo
Console.WriteLine("\n===== RESULTADOS DEL CÍRCULO =====");
Console.WriteLine($"Radio: {radio:N2}");
Console.WriteLine($"Área del círculo: {areaCirculo:N2}");
Console.WriteLine($"Circunferencia: {circunferencia:N2}");

// Mostrar los resultados del triángulo
Console.WriteLine("\n===== RESULTADOS DEL TRIÁNGULO =====");
Console.WriteLine($"Base: {baseTriangulo:N2}");
Console.WriteLine($"Altura: {alturaTriangulo:N2}");
Console.WriteLine($"Área del triángulo: {areaTriangulo:N2}");
Console.WriteLine($"Hipotenusa: {hipotenusa:N2}");
    }
}
