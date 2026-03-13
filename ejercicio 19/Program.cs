Console.Write("Ingrese el nombre del estudiante: ");
string nombreEst = Console.ReadLine();

Console.Write("Ingrese la primera nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la tercera nota: ");
double nota3 = double.Parse(Console.ReadLine());

string mensajeFinal = ObtenerResultadoEstudiante(nombreEst, nota1, nota2, nota3);

Console.WriteLine(mensajeFinal);

string ObtenerResultadoEstudiante(string nombre, double n1, double n2, double n3)
{
    double promedio = (n1 + n2 + n3) / 3;
    return "El estudiante " + nombre + " tiene un promedio final de: " + promedio;
}