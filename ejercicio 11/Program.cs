Console.WriteLine("Ingrese su peso en kg: ");
double peso = double.Parse(Console.ReadLine());

double pesoEnLibras = ConvertirKgALibras(peso);
Console.WriteLine("Su peso en libras es: " + pesoEnLibras);

double ConvertirKgALibras(double peso)
{
    double pesoEnLibras = peso * 2.2;
    return pesoEnLibras;
}