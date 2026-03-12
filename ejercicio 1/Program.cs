Console.Write("Ingrese el primer número:");
int numero1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número:");
int numero2 = int.Parse(Console.ReadLine());

int resultado = sumarNumeros(numero1, numero2);
Console.Write("La suma de los 2 números es: " + resultado);

int sumarNumeros(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    return resultado;
}