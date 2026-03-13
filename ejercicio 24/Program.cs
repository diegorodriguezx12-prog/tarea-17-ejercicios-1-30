void CalcularYMostrarAreaCirculo()
{
    Console.Write("Ingrese el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine());

    double area = Math.PI * Math.Pow(radio, 2);

    Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
}