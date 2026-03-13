Console.WriteLine("Ingrese su distancia recorrida (km): ");
double distancia = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su tiempo (Horas): ");
double horas = double.Parse(Console.ReadLine());

double resultado = CalcularVelocidadPromedio(distancia, horas);

Console.WriteLine("La velocidad promedio es: " + resultado + " km/h");

Double CalcularVelocidadPromedio(double distancia, double horas)
{
    double velocidadPromedio = distancia / horas;
    return velocidadPromedio;
}