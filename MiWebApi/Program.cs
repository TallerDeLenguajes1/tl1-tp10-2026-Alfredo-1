using espacioChistes;

var url = "https://official-joke-api.appspot.com/random_ten";

// Crea una nueva instancia (un objeto) de nuestra clase 'ConsultasAPI' para poder usar sus métodos
ConsultasAPI cliente = new ConsultasAPI();
// Llama al método asincrónico 'ObtenerTareas', espera a que termine (await) y guarda la lista de chistes recibida
List<Chistes> chistes = await cliente.ObtenerTareas(url);
//creo las listas vacias para guardar los chistes segun su tipo
List<Chistes> General = new List<Chistes>();
List<Chistes> Programacion = new List<Chistes>();
List<Chistes> KnockKnock = new List<Chistes>();
List<Chistes> Padres = new List<Chistes>();

FiltrarLista(chistes, General, Programacion, KnockKnock, Padres);
//mostrara solo las listas que tengan chistes
MostrarChistes(General, Programacion, KnockKnock, Padres);

void FiltrarLista (List<Chistes> chistes, List<Chistes> general, List<Chistes> programacion,List<Chistes> knocKnock, List<Chistes> padres)
{
    foreach(var chiste in chistes)
    {
        switch (chiste.type)//dependiendo el tipo de chiste que sea se guarda en la lista que le corresponde
        {
            case "general":
                general.Add(chiste);
                break;
            case "knock-knock":
                knocKnock.Add(chiste);
                break;
            case "programming":
                programacion.Add(chiste);
                break;
            case "dad":
                padres.Add(chiste);
                break;
            default:
            break;
        }
    }
}

static void MostrarChistes(List<Chistes> general, List<Chistes> programacion,List<Chistes> knocKnock, List<Chistes> padres)
{
    if(general.Any())//si la lista general no esta vacia entonces mostrara la lista
    {
        Console.WriteLine("\n     --------------------\n-----| chistes Generales |-----\n     --------------------\n");
        foreach (var chiste in general)
        {
            Console.WriteLine(chiste.mostrarChistePorPantalla());
        }
    }
    if(programacion.Any())//si la lista programacion no esta vacia entonces mostrara la lista
    {
        Console.WriteLine("\n     ---------------------------\n-----| chistes de Programacion |-----\n     ---------------------------\n");
        foreach (var chiste in programacion)
        {
            Console.WriteLine(chiste.mostrarChistePorPantalla());
        }
    }
    if(knocKnock.Any())//si la lista gknockKnock no esta vacia entonces mostrara la lista
    {
        Console.WriteLine("\n     -------------------------\n-----| chistes Knock - Knock |-----\n     -------------------------\n");
        foreach (var chiste in knocKnock)
        {
            Console.WriteLine(chiste.mostrarChistePorPantalla());
        }
    }
    if(padres.Any())//si la lista padres no esta vacia entonces mostrara la lista
    {
        Console.WriteLine("\n     --------------------\n-----| chistes de Padres|-----\n     --------------------\n");
        foreach (var chiste in padres)
        {
            Console.WriteLine(chiste.mostrarChistePorPantalla());
        }
    }
}