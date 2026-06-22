namespace espacioTraduccion;
// Esta es la clase principal que representa el JSON externo
public class RespuestaTraduccion
{
    // Mapea el objeto "responseData" del JSON
    public DatosRespuesta responseData { get; set; }
}

// Esta clase representa lo que hay DENTRO de "responseData"
public class DatosRespuesta
{
    // Mapea el string "translatedText" que tiene la traducción real
    public string translatedText { get; set; }
}