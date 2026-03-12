Console.WriteLine("Ingrese Cuanto gana por hora");
double salarioHora = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cuantas horas trabaja al día");
double horasDia = double.Parse(Console.ReadLine());

double salarioSemanal = CalcularSalarioSemanal(salarioHora, horasDia);
Console.WriteLine("El salario semanal es: " + salarioSemanal);

double CalcularSalarioSemanal(double salarioHora, double horasDia)
{
    double salarioSemanal = salarioHora * horasDia * 7;
    return salarioSemanal;
}