using System.Text.Json.Serialization;
namespace espacioEmpresa;
public class Empresa
{
    [JsonPropertyName("name")]
    string Nombre {get; set;}

    [JsonPropertyName("catchPhrase")]
    string Eslogan {get; set;}

    [JsonPropertyName("bs")]
    string EstrategiasNegocios {get; set;}
}
/*
company": {
    "name": "Romaguera-Crona",
    "catchPhrase": "Multi-layered client-server neural-net",
    "bs": "harness real-time e-markets"
}*/