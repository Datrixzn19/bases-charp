//Listas

//gestionar carrito, permite agregar, eliminar el ultimo, ver el carrito, y cerrar el programa
using System.Collections.Generic; // no parece ser usado me confundi con esto 

namespace GestorCarrito.Logica;



public class Gestor
{
    private List<string> _carrito = new List<string>();
    //_stock = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase); esto me da error
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

using GestorCarrito.Logica;

using System.Collections.Generic; // veo que no lo necesito aqui pero ahi lo dejo
var gestor = new Gestor();//instanciamos la clase 

Console.WriteLine("GESTOR DE CARRITO");
bool esActivo = true; //para salir del while 


    //no las pongo dentro del while porque es molestso ocupan mucho espacio
    Console.WriteLine("Elije el numero segun la opcion");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Eliminar ultimo producto");
    Console.WriteLine("3. Ver carrito");
    Console.WriteLine("4. Salir"); 
do
{


    int opcion;
    while(!int.TryParse(Console.ReadLine(), out opcion ))
    {
        Console.WriteLine("Por favor elije una de las opciones dadas.");
    }
    

    switch (opcion)
    {
        case 1:
            Console.WriteLine("case 1");
            Console.WriteLine("Ingrese el producto que va a agregar: ");
            string opc1 = Console.ReadLine();
            gestor.Agregar(opc1);
            break;
        case 2:
            gestor.EliminarUltimo();
            break;

        case 3:
            List<string> carrito = gestor.ObtenerCarrito();//guardamos la lista que nos paso el metodo 
            
            foreach (var item in carrito)
            {
                Console.WriteLine($"- {item}");
            }
            break;

        case 4:
        Console.WriteLine("Programa cerrado");
            esActivo = false; //cambiamos a false asi ya no se ejecuta el while
            break;
        default:
            Console.WriteLine("Numero de opcion no disponible");
            break;

        
    }


}
while (esActivo);



*/