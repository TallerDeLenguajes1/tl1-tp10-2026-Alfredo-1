namespace espacioChistes;
public class Chistes
{
    public string type {get; set;}
    public string setup {get; set;}
    public string punchline {get; set;}
    public int id {get; set;}
    public string mostrarChistePorPantalla()
    {
        return $"Chiste n°: {id}.\nTipo: {type}\nIntro: {setup}.\nRemate: {punchline}.\n";
    }
}