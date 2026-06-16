using System.Text.Json.Serialization;

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

    /*public Tarea(int idUsuario, int id, string titulo, bool completa)
    {
        UsuarioId = idUsuario;
        ID = id;
        Titulo = titulo;
        Completo = completa;
    }*/
    public string mostrarPorPantalla()
    {
        return $"Id Usuario: {UsuarioId} ID: {ID} Titulo: {Titulo} Estado completo: {Completo}";
    }
}