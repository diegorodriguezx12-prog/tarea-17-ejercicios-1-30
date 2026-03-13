void CalcularYMostrarAreaRectangulo()
{
    Console.Write("Ingrese la base del rectángulo: ");
    double baseRect = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la altura del rectángulo: ");
    double alturaRect = double.Parse(Console.ReadLine());

    double area = baseRect * alturaRect;

    Console.WriteLine("El área del rectángulo es: " + area);
}