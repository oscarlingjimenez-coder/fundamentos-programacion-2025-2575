namespace Calificacion;

class Program
{
    static void Main(string[] args)
    {
        // Declarar las variables
            int nota;
            string letra;

            // Solicitar la calificación
            Console.Write("Ingrese una nota entre 0 y 100: ");
            string entrada = Console.ReadLine() ?? "";

            // Validar que la entrada sea un número entero
            if (int.TryParse(entrada, out nota) && nota >= 0 && nota <= 100)
            {
                // Determinar la letra correspondiente
                if (nota >= 90)
                {
                    letra = "A";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                }
                else
                {
                    letra = "F";
                }

                // Mostrar el resultado
                Console.WriteLine($"Calificación numérica: {nota}");
                Console.WriteLine($"Calificación en letra: {letra}");
            }
            else
            {
                Console.WriteLine("Error: debe ingresar un número entero entre 0 y 100.");
            }
    }
}
