namespace GestionEvento.Seguridad;

public class Portero
{
    // Método que decide si alguien entra o no (Lógica pura)
    // Recibe la edad y un booleano que indica si tiene pase
    public bool PuedeEntrar(int edad, bool tieneInvitacion)
    {
        // Regla: Es mayor de edad Y tiene invitación
        bool esVip = edad >= 18 && tieneInvitacion;

        // Regla: Es mayor de 65 (Entra por cortesía sin importar invitación)
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