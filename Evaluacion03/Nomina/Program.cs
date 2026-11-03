namespace Nomina;

class Program
{
    static void Main(string[] args)
    {
       // Constantes para los descuentos
const double PORCENTAJE_AFP = 0.0287;
const double PORCENTAJE_SFS = 0.0304;

// Datos del empleado
string nombre;
double horasTrabajadas;
double pagoPorHora;

// Variables para los cálculos
double salarioBruto;
double descuentoAFP;
double descuentoSFS;
double salarioNeto;

// Solicitar el nombre del empleado
Console.Write("Ingrese el nombre del empleado: ");
nombre = Console.ReadLine() ?? "";

// Solicitar las horas trabajadas
Console.Write("Ingrese las horas trabajadas: ");
horasTrabajadas = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture
);

// Solicitar el pago por hora
Console.Write("Ingrese el pago por hora: ");
pagoPorHora = double.Parse(
    Console.ReadLine() ?? "",
    System.Globalization.CultureInfo.InvariantCulture
);

// Calcular el salario bruto
salarioBruto = horasTrabajadas * pagoPorHora;

// Calcular los descuentos
descuentoAFP = salarioBruto * PORCENTAJE_AFP;
descuentoSFS = salarioBruto * PORCENTAJE_SFS;

// Calcular el salario neto
salarioNeto = salarioBruto - descuentoAFP - descuentoSFS;

// Mostrar el resumen de la nómina
Console.WriteLine("\n========== RESUMEN DE NÓMINA ==========");

Console.WriteLine($"Empleado: {nombre.ToUpper()}");
Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
Console.WriteLine($"Pago por hora: RD${pagoPorHora:N2}");

Console.WriteLine("---------------------------------------");

Console.WriteLine($"Salario bruto: RD${salarioBruto:N2}");
Console.WriteLine($"Descuento AFP (2.87%): RD${descuentoAFP:N2}");
Console.WriteLine($"Descuento SFS (3.04%): RD${descuentoSFS:N2}");

Console.WriteLine("---------------------------------------");

Console.WriteLine($"Salario neto: RD${salarioNeto:N2}");

    }
}
