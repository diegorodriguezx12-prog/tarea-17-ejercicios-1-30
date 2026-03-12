Console.Write("¿Cuántos productos compraste? ");
int cantidad = int.Parse(Console.ReadLine());

int contador = 1;
double totalSuma = 0;
while (contador <= cantidad)
{
    Console.Write("Ingrese el precio del producto " + contador + ": ");
    double precio = double.Parse(Console.ReadLine());
    totalSuma = totalSuma + precio;
    contador++;
}
Console.WriteLine("El total de su compra es: Q" + totalSuma);