namespace ColeccionJuegos.Logica;

public enum Categorias
{
    Accion, 
    RPG, 
    Deportes
}
public class Videojuego
{
    public string Titulo{get; set;}
    public int AnioLanzamiento{get; set;}
    public Categorias Categoria{get; set;}
}