using System.Text.Json;
using espacioChistes;
public class ConsultasAPI
{
    // Creamos una única instancia estática de HttpClient para toda la aplicación
    private static HttpClient cliente = new HttpClient();
    public async Task<List<Chistes>> ObtenerTareas(string url)
    {
        // Enviamos la solicitud GET usando la instancia estática
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        
        // Verifica si la petición HTTP fue exitosa
        respuesta.EnsureSuccessStatusCode();
        
        // Guardo el cuerpo de la respuesta
        string respuestaJSON = await respuesta.Content.ReadAsStringAsync();
        
        // Deserializo la lista de chistes
        List<Chistes> chistes = JsonSerializer.Deserialize<List<Chistes>>(respuestaJSON);
        
        return chistes;
    }
}