void MostrarCantidadEstudiantes()
{
    Console.Write("¿Cuántos estudiantes hay inscritos en el curso? ");
    int cantidad = int.Parse(Console.ReadLine());

    Console.WriteLine("Actualmente hay " + cantidad + " estudiantes en la clase.");
}