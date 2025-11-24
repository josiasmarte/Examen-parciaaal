using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombreEstudiante = Console.ReadLine();

        Console.Write("Ingrese la cantidad de asignaturas: ");
        int cantidadAsig = int.Parse(Console.ReadLine());

        string[] nombresAsignaturas = new string[cantidadAsig];
        double[,] calificaciones = new double[cantidadAsig, 4];
        double[] promediosAsignaturas = new double[cantidadAsig];

        for (int i = 0; i < cantidadAsig; i++)
        {
            Console.Write($"\nNombre de la asignatura #{i + 1}: ");
            nombresAsignaturas[i] = Console.ReadLine();

            double suma = 0;

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Calificación {j + 1}: ");
                calificaciones[i, j] = double.Parse(Console.ReadLine());
                suma += calificaciones[i, j];
            }

            promediosAsignaturas[i] = suma / 4;
        }

        // Imprimir resultados
        Console.WriteLine("\n=============================");
        Console.WriteLine($"Estudiante: {nombreEstudiante}");
        Console.WriteLine("=============================");

        double sumaGeneral = 0;

        for (int i = 0; i < cantidadAsig; i++)
        {
            Console.WriteLine($"\nAsignatura: {nombresAsignaturas[i]}");
            Console.Write("Calificaciones: ");

            for (int j = 0; j < 4; j++)
            {
                Console.Write(calificaciones[i, j] + "  ");
            }

            Console.WriteLine($"\nPromedio: {promediosAsignaturas[i]:0.00}");
            sumaGeneral += promediosAsignaturas[i];
        }

        double promedioGeneral = sumaGeneral / cantidadAsig;

        Console.WriteLine("\n=============================");
        Console.WriteLine($"Promedio General del Estudiante: {promedioGeneral:0.00}");
        Console.WriteLine("=============================");
    }
}
