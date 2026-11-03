namespace Factura;

class Program
{
    static void Main(string[] args)
    {
       // Constantes para el ITBIS (18%
       const double PORCENTAJE_ITBIS = 0.18;


// Datos del producto
string producto;
int cantidad;
double precio;

// Variables para los cálculos
double subtotal;
double itbis;
double total;

// Solicitar el nombre del producto
Console.Write("Ingrese el nombre del producto: ");
producto = Console.ReadLine() ?? "";

// Solicitar la cantidad de productos
Console.Write("Ingrese la cantidad de productos: ");
cantidad = int.Parse(Console.ReadLine() ?? "");

// Solicitar el precio unitario
Console.Write("Ingrese el precio por unidad: ");
precio = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture

);

// Calcular el subtotal
subtotal = cantidad * precio;

// Calcular el ITBIS (18%)
itbis = subtotal * PORCENTAJE_ITBIS;

// Calcular el total de la factura
total = subtotal + itbis;

// Mostrar la factura
Console.WriteLine("\n========== FACTURA ==========");

// Encabezados de las columnas
Console.WriteLine(
    "Producto".PadRight(20) +
    "Cantidad".PadLeft(10) +
    "Precio".PadLeft(15)
);

Console.WriteLine(new string('-', 45));

// Mostrar los datos del producto
Console.WriteLine(
    producto.PadRight(20) +
    cantidad.ToString().PadLeft(10) +
    precio.ToString("N2").PadLeft(15)
);

Console.WriteLine(new string('-', 45));

// Mostrar los resultados
Console.WriteLine("Subtotal:".PadRight(30) + subtotal.ToString("N2").PadLeft(15));
Console.WriteLine("ITBIS (18%):".PadRight(30) + itbis.ToString("N2").PadLeft(15));
Console.WriteLine("Total a pagar:".PadRight(30) + total.ToString("N2").PadLeft(15));




    }
}
