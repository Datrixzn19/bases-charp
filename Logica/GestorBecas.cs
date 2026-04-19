/*
El Reto: "El Validador de Becas"
Vas a crear un sistema que determine si un estudiante es apto para una beca de manutención.

1. Requisitos funcionales:
El usuario debe ingresar su Promedio Académico (un número con decimales, del 0 al 10).

El usuario debe ingresar sus Ingresos Mensuales familiares (dinero/decimal).

Regla de la Beca: El estudiante gana la beca si:

Su promedio es mayor o igual a 8.5.

Y sus ingresos mensuales son menores a $600.00.
*/
namespace Escuela.Logica;

public class GestorBecas
{
    //Este método debe devolver un booleano (true si cumple ambas condiciones, false si no).
   public bool EsApto(decimal promedio, decimal ingresos)
    {
        if(promedio >= 8.50m && ingresos<600.00m)
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
}





//program cs
/*
using Escuela.Logica;


rchivo Program.cs

Pedir los datos necesarios.

Usar el método EsApto.

Extra de formato: Mostrar un mensaje final usando el operador ternario (? :) que diga: "¡Felicidades! Beca concedida" o "Lo sentimos, no cumples los requisitos".



Console.WriteLine("SISTEMA DE BECAS");

Console.WriteLine("Porfavor, ingresa tu promedio academico (ej. 9.83)");
decimal promedio = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Por favor, ingresa tus ingresos mensuales (ej. 400.50");
decimal imgresos = decimal.Parse(Console.ReadLine() ?? "0");

var g = new GestorBecas();

bool resultado = g.EsApto(promedio, imgresos);

Console.WriteLine(resultado? "si puedes":"no puedes");
*/