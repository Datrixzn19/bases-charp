namespace GestionEvento.Logica;

public class Portero
{

    // Recibe la edad y un booleano que indica si tiene pase
    public bool PuedeEntrar(int edad, bool tieneInvitacion)
    {
        //Es mayor de edad Y tiene invitación
        bool esVip = edad >= 18 && tieneInvitacion;

        //Es mayor de 65 (Entra por cortesía sin importar invitación)
        bool esCortesia = edad > 65;

        // Si cualquiera de las dos es verdadera, retorna true
        return esVip || esCortesia;
    }

    // Método que genera el mensaje final
    public string ObtenerMensaje(bool accesoConcedido, string nombre)
    {
        // Operador Ternario: Es un 'if/else' en una sola línea
        // Sintaxis: [condicion] ? [valor_si_true] : [valor_si_false]
        return accesoConcedido 
            ? $"Bienvenido, {nombre}. Disfrute el evento." 
            : $"Lo sentimos, {nombre}. No cumple los requisitos de acceso.";
    }
}


        //program cs
/*
using GestionEvento.Logica;

// Captura de datos
Console.Write("Nombre del invitado: ");
string nombre = Console.ReadLine() ?? "Anónimo";

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine() ?? "0");

Console.Write("¿Tiene invitación? (si/no): ");
string respuesta = Console.ReadLine()?.ToLower() ?? "";


// Si lo que escribió es "si", la variable será 'true'. De lo contrario 'false'.
bool tienePase = (respuesta == "si");

// instancia de la clase 
var miPortero = new Portero();

//  Validamos la lógica
bool resultado = miPortero.PuedeEntrar(edad, tienePase);

// Obtenemos el mensaje personalizado
string mensaje = miPortero.ObtenerMensaje(resultado, nombre);

Console.WriteLine("\n-------------------------");
Console.WriteLine(mensaje);

*/