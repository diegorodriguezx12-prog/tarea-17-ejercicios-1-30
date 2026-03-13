Console.Write("¿Cuántos productos desea facturar? ");
int cantidad = int.Parse(Console.ReadLine());

double[] factura = new double[cantidad];
int contador = 0;

while (contador < cantidad)
{
    Console.Write("Ingrese el precio del producto " + (contador + 1) + ": ");
    factura[contador] = double.Parse(Console.ReadLine());
    contador++;
}
double totalFinal = CalcularTotalFactura(factura);

Console.WriteLine("El total de su factura es: Q" + totalFinal);

double CalcularTotalFactura(double[] precios)
{
    double total = 0;
    int i = 0;

    while (i < precios.Length)
    {
        total = total + precios[i];
        i++;
    }

    return total;
}