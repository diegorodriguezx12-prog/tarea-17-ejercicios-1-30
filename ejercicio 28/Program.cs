void CalcularYMostrarPromedio()
{
    Console.Write("Ingrese la primera calificación: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la segunda calificación: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la tercera calificación: ");
    double nota3 = double.Parse(Console.ReadLine());


    double promedio = (nota1 + nota2 + nota3) / 3;

    Console.WriteLine("El promedio final del estudiante es: " + promedio);
}