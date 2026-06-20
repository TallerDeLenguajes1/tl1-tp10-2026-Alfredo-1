using System.Text.Json.Serialization;
using espacioLocalizacion;
namespace espacioDireccion;
public class Direccion
{
    [JsonPropertyName("street")]
    public string Calle {get; set;}

    [JsonPropertyName("suite")]
    public string Departamento {get; set;}

    [JsonPropertyName("city")]
    public string Ciudad {get; set;}

    [JsonPropertyName("zipcode")]
    public string CodigoPostal {get; set;}

    [JsonPropertyName("geo")]
    public Localizacion GeoLocalizacion {get; set;}= new Localizacion();
    
}
/*
address": {
    "street": "Kulas Light",
    "suite": "Apt. 556",
    "city": "Gwenborough",
    "zipcode": "92998-3874",
    "geo": {
    "lat": "-37.3159",
    "lng": "81.1496"
    }
}*/