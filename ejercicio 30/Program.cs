void GenerarReporteEstudiante()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el nombre del curso: ");
    string curso = Console.ReadLine();

    Console.Write("Ingrese la nota 1: ");
    double n1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la nota 2: ");
    double n2 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la nota 3: ");
    double n3 = double.Parse(Console.ReadLine());

    double promedio = (n1 + n2 + n3) / 3;

    Console.WriteLine("       REPORTE DE CALIFICACIONES      ");
    Console.WriteLine("Estudiante: " + nombre);
    Console.WriteLine("Curso:      " + curso);
    Console.WriteLine("Nota 1:     " + n1);
    Console.WriteLine("Nota 2:     " + n2);
    Console.WriteLine("Nota 3:     " + n3);
    Console.WriteLine("PROMEDIO:   " + promedio.ToString("N2"));
}