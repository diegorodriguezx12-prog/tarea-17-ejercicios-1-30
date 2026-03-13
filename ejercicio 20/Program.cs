Console.WriteLine("--- Cálculo de Salario ---");

Console.Write("Ingrese la cantidad de días trabajados: ");
int dias = int.Parse(Console.ReadLine());

Console.Write("Ingrese el pago por día: ");
double pago = double.Parse(Console.ReadLine());

double totalRecibir = CalcularSalario(dias, pago);

Console.WriteLine("El salario total a pagar es: Q" + totalRecibir);

double CalcularSalario(int diasTrabajados, double pagoDiario)
{
    double salarioTotal = diasTrabajados * pagoDiario;
    return salarioTotal;
}