Console.Write("Ingrese la cantidad de estudiantes: ");
int cantidad = int.Parse(Console.ReadLine());

double[] listaNotas = new double[cantidad];
int contador = 0;

while (contador < cantidad)
{
    Console.Write("Ingrese la nota del estudiante " + (contador + 1) + ": ");
    listaNotas[contador] = double.Parse(Console.ReadLine());
    contador++;
}

double promedioFinal = CalcularPromedioGrupo(listaNotas);
Console.WriteLine("El promedio general del grupo es: " + promedioFinal);

double CalcularPromedioGrupo(double[] notas)
{
    double sumaNotas = 0;
    int i = 0;

    while (i < notas.Length)
    {
        sumaNotas = sumaNotas + notas[i];
        i++;
    }
    double promedio = sumaNotas / notas.Length;
    return promedio;
}