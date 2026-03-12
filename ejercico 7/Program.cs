Console.Write("Ingrece el precio del producto: ");
double precio = double.Parse(Console.ReadLine());

Console.Write("Ingrese el porcentaje de descuento: ");
double descuento = double.Parse(Console.ReadLine());

double precioConDescuento = CalcularPrecioConDescuento(precio, descuento);
Console.Write("El precio con descuento es: " + precioConDescuento);
double CalcularPrecioConDescuento(double precio, double descuento)
{
    double precioConDescuento = precio - (precio * (descuento / 100));
    return precioConDescuento;
}