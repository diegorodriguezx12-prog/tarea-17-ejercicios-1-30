Console.Write("Por favor, ingresa tu nombre: ");
string nombre = Console.ReadLine();

MostrarBienvenida(nombre);

void MostrarBienvenida(string nombreUsuario)
{
    Console.WriteLine("¡Bienvenido al sistema, " + nombreUsuario + "!");
    Console.WriteLine("Es un gusto saludarte el día de hoy.");
}