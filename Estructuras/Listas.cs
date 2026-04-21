/*
Es la versión moderna y flexible del array. Imagina una fila de personas agarradas de la mano: puedes meter a alguien nuevo en medio o al final en cualquier momento.

Tamaño dinámico: Crece y se encoge automáticamente.
Métodos útiles: Tiene funciones como .Add(), .Remove(), .Sort(), etc.
Genéricos: El <T> significa que debes decirle qué tipo de dato guardará (ej. List<int>).
*/
/*
using System.Collections.Generic; // Necesario para usar listas

List<string> listaNombres = new List<string>();

listaNombres.Add("Pedro"); // Añade al final
listaNombres.Add("Maria");
listaNombres.Remove("Pedro"); // Lo borra automáticamente

Console.WriteLine(listaNombres.Count); // Nos dice cuántos hay (2)


/*
Las listas tienen métodos integrados (vienen "de fábrica") que facilitan mucho la vida:

.Add(valor): Agrega un elemento al final de la lista.

.Insert(indice, valor): Mete un elemento en una posición específica (mueve los demás hacia adelante).

.Remove(valor): Busca el valor y borra la primera coincidencia que encuentre.

.RemoveAt(indice): Borra lo que haya en la posición exacta que le digas.

.Contains(valor): Devuelve true o false si el elemento está en la lista. (Muy útil para validaciones).

.Clear(): Vacía la lista por completo.

.Count: (Es una propiedad) Te dice cuántos elementos hay actualmente.
*/