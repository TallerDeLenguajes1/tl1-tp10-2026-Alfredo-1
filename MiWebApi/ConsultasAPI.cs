using System.Text.Json;
using espacioChistes;
using espacioTraduccion;
using System.Web;
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

    public async Task<string> TraducirChistes(string chiste)
    {
        // codifico el texto para que caracteres como espacios o signos de pregunta no rompan la URL
        string textoCodificado = HttpUtility.UrlEncode(chiste);
        string url = $"https://api.mymemory.translated.net/get?q={textoCodificado}&langpair=en|es";
        // Enviamos la solicitud GET usando la instancia estática
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        // Verifica si la petición HTTP fue exitosa
        respuesta.EnsureSuccessStatusCode();
        // Guardo el cuerpo de la respuesta
        string respuestaJSON = await respuesta.Content.ReadAsStringAsync();

        // Deserializo directamente en nuestra clase armada
        RespuestaTraduccion chisteTraducido = JsonSerializer.Deserialize<RespuestaTraduccion>(respuestaJSON);

        //accedo de forma escalonada objeto.propInterna.elString
        return chisteTraducido.responseData.translatedText;
    }
}