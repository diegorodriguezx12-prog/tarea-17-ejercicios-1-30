Console.Write("Ingrese la cantidad de minutos: ");
int minIngresados = int.Parse(Console.ReadLine());

double resultadoHoras = ConvertirMinutosAHoras(minIngresados);

Console.WriteLine(minIngresados + " minutos equivalen a: " + resultadoHoras + " horas.");

double ConvertirMinutosAHoras(int minutos)
{
    double horas = minutos / 60.0;
    return horas;
}