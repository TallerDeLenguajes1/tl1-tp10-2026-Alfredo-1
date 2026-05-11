namespace espacioTarea;
public class Tarea{
    public int UsuarioId;
    public int ID;
    public string? Titulo;
    public bool Completa;

    public Tarea(int idUsuario, int id, string titulo, bool completa)
    {
        UsuarioId = idUsuario;
        ID = id;
        Titulo = titulo;
        Completa = completa;
    }
}