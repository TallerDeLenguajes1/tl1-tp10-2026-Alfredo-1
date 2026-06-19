using System.ComponentModel;
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
        {   //si tarea esta commpleta le agrego un estado que diga Completada.
            tarea.Estado ="Completada";
            tareasCompletas.Add(tarea);
        }else
        {   //si la tarea aun no se completo, su estado dira Pendiente.
            tarea.Estado="Pendiente";
            tareasPendientes.Add(tarea);
        }
    }
}

