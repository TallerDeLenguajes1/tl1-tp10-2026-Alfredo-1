using espacioUsuario;

string url = "https://jsonplaceholder.typicode.com/users/";
ConsultasAPI cliente = new ConsultasAPI();
List<Usuario> usuarios = await cliente.ObtenerTareas(url);
int cantidad=5;
MostrarUsuarios(usuarios, cantidad);


static void MostrarUsuarios(List<Usuario> usuarios, int cantidad)
{
    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine(usuarios[i].mostrarUsuarios());
    }
}