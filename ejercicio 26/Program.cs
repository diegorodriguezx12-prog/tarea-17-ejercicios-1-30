void CalcularAnioNacimiento()
{
    Console.Write("Ingrese su edad: ");
    int edad = int.Parse(Console.ReadLine());

    int anioActual = 2026;
    int anioNacimiento = anioActual - edad;

    Console.WriteLine("Tu año aproximado de nacimiento es: " + anioNacimiento);
    Console.WriteLine("(Nota: Esto puede variar dependiendo de si ya cumpliste años este año).");
}