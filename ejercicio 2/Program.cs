Console.Write("Ingrese el número que desea elevar al cuadrado: ");
int numero = int.Parse(Console.ReadLine());

int resultado = elevarNumeroAlCuadrado(numero);
Console.WriteLine("El resultado de elevar el número al cuadrado es: " + resultado);

int elevarNumeroAlCuadrado(int numero)
{
    int resultado = numero * numero;
    return resultado;
}