Console.Write("Ingrese el primer número: ");
double n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double n2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer número: ");
double n3 = int.Parse(Console.ReadLine());

double resultado = calcularpromedio(n1, n2, n3);
Console.Write("El promedio de los 3 números es: " + resultado);

double calcularpromedio(double n1, double n2, double n3)
{
    double resultado = (n1 + n2 + n3) / 3;
    return resultado;
}