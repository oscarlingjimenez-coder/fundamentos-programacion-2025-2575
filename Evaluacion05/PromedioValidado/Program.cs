namespace PromedioValidado;

class Program
{
    static void Main(string[] args)
    {
        // Variable para almacenar cada calificación
double calificacion;

// Acumulador de las calificaciones
double sumaCalificaciones = 0;

// Contador de calificaciones válidas
int cantidadCalificaciones = 0;

// Variables para la nota máxima y mínima
double notaMaxima = 0;
double notaMinima = 100;

// Variable para calcular el promedio
double promedio;


// Mostrar mensaje de bienvenida
Console.WriteLine("===== PROMEDIO VALIDADO =====");
Console.WriteLine("Ingrese calificaciones entre 0 y 100.");
Console.WriteLine("Escriba -1 para finalizar.");

// Solicitar y validar las calificaciones
do
{
    Console.Write("\nIngrese una calificacion: ");
    string entrada = Console.ReadLine() ?? "";

    // Validar que la entrada sea un número
    if (!double.TryParse(
        entrada,
        System.Globalization.NumberStyles.Float,
        System.Globalization.CultureInfo.InvariantCulture,
        out calificacion) || !double.IsFinite(calificacion))
    {
        Console.WriteLine("Error: ingrese un numero valido.");
        continue;
    }

    // Finalizar cuando el usuario escriba -1
    if (calificacion == -1)
    {
        break;
    }

    // Validar el rango permitido
    if (calificacion < 0 || calificacion > 100)
    {
        Console.WriteLine("Error: la calificacion debe estar entre 0 y 100.");
        continue;
        }

        // Acumular las calificaciones válidas
sumaCalificaciones += calificacion;

// Contar las calificaciones registradas
cantidadCalificaciones++;

// Identificar la calificación más alta
if (calificacion > notaMaxima)
{
    notaMaxima = calificacion;
}

// Identificar la calificación más baja
if (calificacion < notaMinima)
{
    notaMinima = calificacion;
}

// Confirmar el registro
Console.WriteLine("Calificacion registrada correctamente.");
    }

 while (calificacion != -1);
// Verificar que se hayan registrado calificaciones
if (cantidadCalificaciones > 0)
{
    // Calcular el promedio
    promedio = sumaCalificaciones / cantidadCalificaciones;

    // Mostrar los resultados
    Console.WriteLine("\n===== RESULTADOS FINALES =====");

    Console.WriteLine($"Calificaciones registradas: {cantidadCalificaciones}");

    Console.WriteLine($"Promedio: {promedio:N2}");

    Console.WriteLine($"Nota maxima: {notaMaxima:N2}");

    Console.WriteLine($"Nota minima: {notaMinima:N2}");

    Console.WriteLine("==============================");
}
else
{
    Console.WriteLine("\nNo se registraron calificaciones validas.");
}



    }
}
