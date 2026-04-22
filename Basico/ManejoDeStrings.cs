/*
1. Manejo de Strings (El arte de limpiar datos)
Cuando recibes texto del usuario, casi nunca viene "limpio". C# tiene herramientas para normalizarlo:

.Trim(): Quita espacios en blanco al inicio y al final. Es vital para que " hola" sea igual a "hola".

.ToUpper() / .ToLower(): Convierte todo a mayúsculas o minúsculas. Ideal para comparaciones.

string.IsNullOrWhiteSpace(variable): Es la forma más segura de saber si un texto está vacío o solo tiene espacios.

.Split(caracter): Rompe un string y lo convierte en un Array. Muy útil para procesar listas separadas por comas.
*/