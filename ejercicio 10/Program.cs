Console.Write("Ingrese el número que quiera elevar al cubo: ");
int numero = int.Parse(Console.ReadLine());

int resultado = elevarNumeroAlCubo(numero);
Console.Write("El resultado de elevar el número al cubo es: " + resultado);

int elevarNumeroAlCubo(int numero)
{
    int resultado = numero * numero * numero;
    return resultado;
}