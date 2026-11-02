namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
       // Declarar las variables
      int x;
      int y;

      // solicitar el primer numero 
Console.Write("Ingrese el primer número: ");
x= int.Parse(Console.ReadLine() ?? "");

// solicitar el segundo numero
Console.Write("Ingrese el segundo número: ");
y= int.Parse(Console.ReadLine() ?? "");

// declarar las operaciones aritméticas
int suma = x + y;
int resta = x - y;
int multiplicacion = x * y;

//Verificar que el segundo numero no sea cero 
if (y== 0)
{
    Console.WriteLine("Error: No se puede dividir entre cero.");
    return;
}

// Calcular la división real
double division = (double)x / y;

// Calcular la división entera
int divisionEntera = x / y;

// Calcular el residuo
int residuo = x % y;

// Comprobar si el primer numero es par 
bool esPar = x % 2 == 0;

// Mostrar los resultados de las operaciones
Console.WriteLine("\n--- RESULTADOS DE LAS OPERACIONES ---");

Console.WriteLine($"Primer número: {x}");
Console.WriteLine($"Segundo número: {y}");
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Resta: {resta}");
Console.WriteLine($"Multiplicación: {multiplicacion}");
Console.WriteLine($"División real: {division:F2}");
Console.WriteLine($"División entera: {divisionEntera}");
Console.WriteLine($"Residuo: {residuo}");
Console.WriteLine($"¿El primer número es par?: {esPar}");
    }
}

/* PRUEBA DE ESCRITORIO

Valores 
x = 10 
y = 3
Suma: 10 + 3 = 13
Resta: 10 - 3 = 7
Multiplicación: 10 * 3 = 30
División real: 10 / 3 = 3.33
División entera: 10 / 3 = 3
Residuo: 10 % 3 = 1
¿El primer número es par?: True

Conclusión:
Los resultados coinciden con las operaciones
matemáticas esperadas.
*/
