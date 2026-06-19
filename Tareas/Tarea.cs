using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace espacioTarea;
public class Tarea{
    [JsonPropertyName("userId")]
    public int UsuarioId{get; set;}
    [JsonPropertyName("id")]
    public int ID{get; set;}
    [JsonPropertyName("title")]
    public string Titulo{get; set;}
    [JsonPropertyName("completed")]
    public bool Completo{get; set;}
    public string Estado{get; set;}
    public string mostrarPorPantalla()
    {
        return $"Titulo: {Titulo, -80} | Estado : {Estado, -10} ";
    }
}