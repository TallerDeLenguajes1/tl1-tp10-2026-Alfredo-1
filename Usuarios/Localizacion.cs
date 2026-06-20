using System.Text.Json.Serialization;
namespace espacioLocalizacion;
public class Localizacion
{
    [JsonPropertyName("lat")]
    public double Latitud {get; set;}

    [JsonPropertyName("lng")]
    public double Longitud {get; set;}

}
/*
"geo": {
    "lat": "-37.3159",
    "lng": "81.1496"
}*/