Console.Write("Ingrese el número: ");
int numero = int.Parse(Console.ReadLine());

int resultado = dobleDelNumero(numero);
Console.Write("El doble del número es: " + resultado);

int dobleDelNumero(int numero)
{
    int resultado = numero * 2;
    return resultado;
}