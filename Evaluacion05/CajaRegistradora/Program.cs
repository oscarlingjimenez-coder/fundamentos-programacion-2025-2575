namespace CajaRegistradora;

class Program
{
    static void Main(string[] args)
    {
        // Constante del ITBIS (18%
        const decimal PORCENTAJE_ITBIS = 0.18m;

        //Variables para registrar los productos 
        decimal precio;
        int cantidadProductos = 0;


        //Variables para calculos
        decimal subtotal = 0;
        decimal itbis;
        decimal total;


        //Solicitar los precios de los productos 
        do
        {
           Console.Write("Ingrese el precio del producto (0 para terminar): ");
    string entrada = Console.ReadLine() ?? "";

    // Validar que el precio sea un número válido
    if (!decimal.TryParse(
        entrada,
        System.Globalization.NumberStyles.Number,
        System.Globalization.CultureInfo.InvariantCulture,
        out precio))
    {
        Console.WriteLine("Error: ingrese un precio válido.");
        precio = -1m;
        continue;
    }

    // Verificar que el precio no sea negativo
    if (precio < 0)
    {
        Console.WriteLine("Error: el precio no puede ser negativo.");
        continue;
    }

    // Registrar el producto si el precio es mayor que cero
    if (precio > 0)
    {
        subtotal = subtotal + precio;
        cantidadProductos++;

        Console.WriteLine("Producto registrado correctamente.");
    }

} while (precio != 0);

// Calcular el ITBIS del 18%
itbis = subtotal * PORCENTAJE_ITBIS;

// Calcular el total de la compra
total = subtotal + itbis;

// Mostrar el resumen de la compra
Console.WriteLine("\n===== CAJA REGISTRADORA =====");

Console.WriteLine($"Productos registrados: {cantidadProductos}");

Console.WriteLine("------------------------------");

// Mostrar los valores con dos decimales
Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
Console.WriteLine($"Total a pagar: RD$ {total:N2}");

Console.WriteLine("==============================");
    }
}
