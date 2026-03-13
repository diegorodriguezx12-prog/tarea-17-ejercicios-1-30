Console.WriteLine("--- Calculadora de Área de Triángulos ---");

Console.Write("Ingrese la base del triángulo: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del triángulo: ");
double h = double.Parse(Console.ReadLine());

double resultado = CalcularAreaTriangulo(b, h);
Console.WriteLine("El área del triángulo es: " + resultado);

double CalcularAreaTriangulo(double baseTri, double altura)
{
    double area = (baseTri * altura) / 2;
    return area;
}