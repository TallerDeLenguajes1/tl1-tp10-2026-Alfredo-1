using espacioUsuario;
using System.Text.Json;
public class ConsultasAPI
{
    // Creamos una única instancia estática de HttpClient para toda la aplicación
    private static HttpClient cliente = new HttpClient();
    public async Task<List<Usuario>> ObtenerTareas(string url)
    {
        //envio una solicitud get a la url
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        //verifica si la peticion HTTP fue exitosa
        respuesta.EnsureSuccessStatusCode();
        //guardo el cuerpo de la respuesta
        string respuestaJSON = await respuesta.Content.ReadAsStringAsync();
        //descerealizo la lista para que pueda leearla
        List<Usuario> usuario = JsonSerializer.Deserialize<List<Usuario>>(respuestaJSON);
        
        return usuario;
    }
}