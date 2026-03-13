void CalcularDescuentoDiezPor Ciento()
{
    Console.Write("Ingrese el precio original del producto: Q");
double precioOriginal = double.Parse(Console.ReadLine());

double descuento = precioOriginal * 0.10;

double precioFinal = precioOriginal - descuento;

Console.WriteLine("Descuento aplicado (10%): Q" + descuento);
Console.WriteLine("El precio final con descuento es: Q" + precioFinal);
}