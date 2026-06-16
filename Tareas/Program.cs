//creamos una instancia de httpClient
using System.Text.Json;
using espacioTarea;

HttpClient cliente = new HttpClient();
//envio una solicitud get a la url
HttpResponseMessage respuesta = await cliente.GetAsync("https://jsonplaceholder.typicode.com/todos/");
//verifica si la peticion HTTP fue exitosa
respuesta.EnsureSuccessStatusCode();
//guardo el cuerpo de la respuesta
string respuestaJSON = await respuesta.Content.ReadAsStringAsync();
List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(respuestaJSON);

foreach(var tarea in tareas)
{
    Console.WriteLine(tarea.mostrarPorPantalla());
}

Console.WriteLine("\n\nfin programa\n");