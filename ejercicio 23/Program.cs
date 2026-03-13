void SolicitarYSumar()
{
    Console.Write("Ingrese el primer número: ");
    double n1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    double n2 = double.Parse(Console.ReadLine());

    double suma = n1 + n2;

    Console.WriteLine("La suma de ambos números es: " + suma);
}