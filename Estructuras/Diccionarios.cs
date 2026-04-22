/*
using System.Collections.Generic;

// Diccionario donde la LLAVE es un string (nombre) y el VALOR es un int (edad)
Dictionary<string, int> edades = new Dictionary<string, int>();

// 1. Agregar elementos
edades.Add("Juan", 25);
edades.Add("Maria", 30);

// 2. Acceder a un valor usando su llave (como si fuera un índice)
Console.WriteLine($"La edad de Juan es: {edades["Juan"]}");
*/





/*
A diferencia de las listas, los diccionarios tienen trucos especiales para no "romperse" si buscas algo que no existe:

.ContainsKey(llave): Devuelve true si la llave existe. Es vital usarlo antes de acceder a un valor para evitar errores.

.Remove(llave): Elimina la pareja completa (llave y valor).

.Count: Te dice cuántas parejas hay.

TryGetVaue(llave, out valor): Intenta obtener el valor de forma segura (mezcla lo que aprendiste de TryParse con diccionarios).
*/