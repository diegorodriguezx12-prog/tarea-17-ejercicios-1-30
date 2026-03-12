Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

string resultado = ResultadoEdad(edad);
Console.WriteLine(resultado);
string ResultadoEdad(int edad)
{
    string resultado = "La edad ingresada es: " +edad+ " años";
    return resultado;
}