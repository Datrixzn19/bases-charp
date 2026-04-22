//programa que pide un producto y devuelve el stock existente

//Diccionarios

namespace ConsultarInventario.Logica;
using System.Collections.Generic;

public class Bodega
{
    private Dictionary<string, int> _stock = new()//nombre del producto, cantidad disponible
    {
    {"jabon", 40},
    {"nutella", 78},
    {"shampoo", 54},
    {"yogurt", 23},
    {"a", 3}
    };


    public string ConsultarStock(string productoBuscado)
    {
        int p;//este es el stock

        if(_stock.TryGetValue(productoBuscado, out p))//lo uso asi porque devuelve true si lo encuntra
        {
            return($"El stock de este producto es de {p}"); 
        }
        else
        {
            return("Producto no disponible"); //no encontrado
        }
        

    }



}




/*

using ConsultarInventario.Logica;
var inventario = new Bodega();


do
{
    Console.WriteLine("Ingrese el producto (o 'salir'): ");
    string opc = Console.ReadLine().ToLower();

    if (opc == "salir") break; // Rompe el bucle antes de llamar a la lógica

    Console.WriteLine(inventario.ConsultarStock(opc));
    
} while (true); // El bucle corre hasta que el 'break' lo detenga
*/