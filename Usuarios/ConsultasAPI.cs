using espacioUsuario;
using System.Text.Json;
public class ConsultasAPI
{
    public async Task<List<Usuario>> ObtenerTareas(string url)
    {
        //creamos una instancia de httpClient
        HttpClient cliente = new HttpClient();
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