Console.WriteLine("Ingrese la base del rectángulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double area = AreaRectangulo(baseRectangulo, alturaRectangulo);
Console.WriteLine("El área del rectángulo es: " + area);

double AreaRectangulo(double baseRectangulo, double alturaRectangulo)
{
    double area = baseRectangulo * alturaRectangulo;
    return area;
}