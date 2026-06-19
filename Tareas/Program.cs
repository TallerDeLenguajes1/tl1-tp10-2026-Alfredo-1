using espacioTarea;

var url = "https://jsonplaceholder.typicode.com/todos/";

ConsultasAPI cliente = new ConsultasAPI();
List<Tarea> tareas = await cliente.ObtenerTareas(url);
MostrarTareas(tareas);

Console.WriteLine("\n\nfin programa\n");

static void MostrarTareas(List<Tarea> tareas)
{
    foreach (var tarea in tareas)
    {
        Console.WriteLine(tarea.mostrarPorPantalla());
    }
}
