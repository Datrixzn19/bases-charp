//Listas

//gestionar carrito, permite agregar, eliminar el ultimo, ver el carrito, y cerrar el programa
using System.Collections.Generic; // no parece ser usado me confundi con esto 

namespace GestorCarrito.Logica;



public class Gestor
{
    private List<string> _carrito = new List<string>();
    public void Agregar(string producto)
    {
        _carrito.Add(producto);
        Console.WriteLine("Producto agregado existosamente");
    }
    public void EliminarUltimo()
    {
        if(_carrito.Count > 0)
        {
            int indiceUltimo = _carrito.Count-1;
            _carrito.RemoveAt(indiceUltimo);
            Console.WriteLine("Ultimo producto eliminado");   
        }   
        else
        {
            Console.WriteLine("el carrito esta vacio");
        }  
    }
    public List<string> ObtenerCarrito()
    {

        
        Console.WriteLine("Carrito completo:");   
        return _carrito;
        
    }

}








/*
2. Requisitos funcionales:
En GestorCarrito.cs:

Crea una clase llamada GestorCarrito.

Dentro, declara una lista privada de strings para los productos: private List<string> _carrito = new List<string>();.

Crea tres métodos:

Agregar(string producto): Usa .Add().

EliminarUltimo(): Usa .RemoveAt() junto con .Count - 1 (pero solo si la lista no está vacía).

ObtenerProductos(): Que devuelva la lista completa para poder mostrarla.



*/