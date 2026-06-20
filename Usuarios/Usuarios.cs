using System.Text.Json.Serialization;
using espacioDireccion;
using espacioEmpresa;
namespace espacioUsuario;
public class Usuario
{
    [JsonPropertyName("id")]
    public int ID {get; set;}

    [JsonPropertyName("name")]
    public string Nombre {get; set;}

    [JsonPropertyName("username")]
    public string NombreUsuario {get; set;}

    [JsonPropertyName("email")]
    public string Correo {get; set;}

    [JsonPropertyName("address")]
    public Direccion direccion {get; set;} = new Direccion();

    [JsonPropertyName("phone")]
    public string Telefono {get; set;}

    [JsonPropertyName("website")]
    public string SitioWeb {get; set;}
    
    [JsonPropertyName("company")]
    public Empresa empresa {get; set;} = new Empresa();

    public string mostrarUsuarios()
    {
        return $" ----------------------------------------------¬\n|Nombre: {Nombre,-38}|\n|Correo Electronico: {Correo,-26}|\n|Direccion:\n|    Calle: {direccion.Calle,-35}|\n|    Ciudad: {direccion.Ciudad,-34}|\n|    Codigo Postal: {direccion.CodigoPostal,-27}|\n|    Departamento: {direccion.Departamento, -28}|\n|    Localizacion:\n|       Lat: {direccion.GeoLocalizacion.Latitud, -34}|\n|       Long: {direccion.GeoLocalizacion.Longitud, -33}|\n|----------------------------------------------|\n";
    }
}
/*
{
    "id": 1,
    "name": "Leanne Graham",
    "username": "Bret",
    "email": "Sincere@april.biz",
    "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }
    },
    "phone": "1-770-736-8031 x56442",
    "website": "hildegard.org",
    "company": {
      "name": "Romaguera-Crona",
      "catchPhrase": "Multi-layered client-server neural-net",
      "bs": "harness real-time e-markets"
    }
}*/