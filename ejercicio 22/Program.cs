void SolicitarNombreYSaludar()
{
    Console.Write("¿Cómo te llamas? ");
    string nombre = Console.ReadLine();
    Console.WriteLine("¡Mucho gusto, " + nombre + "! Es un placer ayudarte con tu código.");
}