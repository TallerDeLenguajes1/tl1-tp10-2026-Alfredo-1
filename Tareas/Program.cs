using System.ComponentModel;
using System.Linq.Expressions;
using System.Text.Json;
using espacioTarea;

var url = "https://jsonplaceholder.typicode.com/todos/";

ConsultasAPI cliente = new ConsultasAPI();
List<Tarea> tareas = await cliente.ObtenerTareas(url);
List<Tarea> tareasCompletas = new List<Tarea>();
List<Tarea> tareasPendientes = new List<Tarea>();
//MostrarTareas(tareas);
FiltrarLista(tareas, tareasCompletas, tareasPendientes);
Console.WriteLine("\n     --------------------\n-----| Tareas Completas |-----\n     --------------------\n");
MostrarTareas(tareasCompletas);
Console.WriteLine("\n     ----------------------\n-----| Tareas Pendientes |-----\n     ----------------------\n");
MostrarTareas(tareasPendientes);
//serealizo la lista
string JsonAGuardar = JsonSerializer.Serialize(tareas);
guardarArchivo(JsonAGuardar);

Console.WriteLine("\n\nfin programa\n");


static void MostrarTareas(List<Tarea> tareas)
{
    foreach (var tarea in tareas)
    {
        Console.WriteLine(tarea.mostrarPorPantalla());
    }
}

void FiltrarLista (List<Tarea> tareas, List<Tarea> tareasCompletas, List<Tarea> tareasPendientes)
{
    foreach(var tarea in tareas)
    {
        if(tarea.Completo)
        {
            tareasCompletas.Add(tarea);
        }else
        {
            tareasPendientes.Add(tarea);
        }
    }
}

void guardarArchivo(string archivo)
{
    string hubicacion = Directory.GetCurrentDirectory();
    string rutaArchivo = Path.Combine(hubicacion, "tareas.json");
    if (File.Exists(rutaArchivo))
    {
        Console.WriteLine("\nEl archivo ya existe...\n");
    }else
    {
        File.WriteAllText(rutaArchivo, archivo);
        Console.WriteLine("\nSe creo exitosamente el archivo\n");
    }
        
}