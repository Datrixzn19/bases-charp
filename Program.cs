using GestionEvento.Seguridad;

// Captura de datos
Console.Write("Nombre del invitado: ");
string nombre = Console.ReadLine() ?? "Anónimo";

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine() ?? "0");

Console.Write("¿Tiene invitación? (si/no): ");
string respuesta = Console.ReadLine()?.ToLower() ?? "";

// Sintaxis compleja: Convertimos el texto a booleano
// Si lo que escribió es "si", la variable será 'true'. De lo contrario 'false'.
bool tienePase = (respuesta == "si");

// Uso de la clase Portero
var miPortero = new Portero();

// 1. Validamos la lógica
bool resultado = miPortero.PuedeEntrar(edad, tienePase);

// 2. Obtenemos el mensaje personalizado
string mensaje = miPortero.ObtenerMensaje(resultado, nombre);

Console.WriteLine("\n-------------------------");
Console.WriteLine(mensaje);