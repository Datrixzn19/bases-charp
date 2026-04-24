namespace GestorDeTareas.Logica;
    public enum EstadoTarea
    {
        Pendiente,
        EnProgreso,
        Terminada,
    }
    public class Tarea
    {

        public string Descripcion {get; set;}
        public int Prioridad {get; set;}
        public EstadoTarea Estado {get; set;}


    }



/*
using GestorDeTareas.Logica;

List<Tarea> misTareas = new List<Tarea>();

// DESCRIPCION
Console.WriteLine("Descripción de la tarea: ");
string descripcion = Console.ReadLine();

// PRIORIDAD
int prioridad = 1; 
try
{
    Console.WriteLine("Prioridad (del 0 al 5):");
    prioridad = int.Parse(Console.ReadLine()); 
}
catch (FormatException)
{
    Console.WriteLine("Error. Se asignará prioridad 1.");
}

// Crear el objeto antes de asignar el estado
Tarea nuevaTarea = new Tarea();
nuevaTarea.Descripcion = descripcion;
nuevaTarea.Prioridad = prioridad;

//Pedir Estado y castear
Console.WriteLine("Estado: (0-Pendiente, 1-EnProgreso, 2-Terminada)");
try
{
    int opcionEstado = int.Parse(Console.ReadLine());
    //convertimos el int a EstadoTarea
    nuevaTarea.Estado = (EstadoTarea)opcionEstado; 
}
catch (FormatException)
{
    nuevaTarea.Estado = EstadoTarea.Pendiente;
}

//Agregar a la lista
misTareas.Add(nuevaTarea);

Console.WriteLine($"Tarea guardada: {nuevaTarea.Descripcion} con estado {nuevaTarea.Estado}");

*/