Console.Write("Ingrese la temperatura en grados Celsius:");
double gradosCelsius = double.Parse(Console.ReadLine());

double gradosFahrenheit = convercionGradosCelsius(gradosCelsius);
Console.Write("La temperatura en grados Fahrenheit es: " + gradosFahrenheit);
double convercionGradosCelsius(double gradosCelsius)
{
    double gradosFahrenheit = gradosCelsius * 1.8 + 32;
    return gradosFahrenheit;
}