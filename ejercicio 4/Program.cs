Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());

double area = AreaDeUnCirculo(radio);
Console.Write("El área del círculo es: " + area);

double AreaDeUnCirculo(double radio)
{
    double area = Math.PI * radio * radio;
    return area;
}