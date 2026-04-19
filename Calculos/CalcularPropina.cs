//pedir el monto que va a pagar y el porcentaje de propina que va a dejar, luego le damos el total
namespace Restaurante.Calculos;


public class CalcularPropina
{
    public decimal calcularTotal(decimal monto, int porcentaje)
    {
        decimal total = monto+(monto*porcentaje/100);//formula para sacar porcentajes
        return total;
    }
}


//monto + (monto*porcentaje/100)

//Program cs
/*


Archivo Program.cs

Pedir el monto (usa decimal).
Pedir el porcentaje (usa int o double).
Mostrar el resultado final.


using Restaurante.Calculos;

//Pedir el monto
Console.WriteLine("Por favor, cual es el monto: ");
int monto = int.Parse(Console.ReadLine() ?? "0");

//Pedir el porcentaje que van a dar de propina
Console.WriteLine("Por favor, cual es el porcentaje: ");
int porcentaje = int.Parse(Console.ReadLine() ?? "0");

//mostrar el resultado

var CalcularPropina = new CalcularPropina();
decimal resultado = CalcularPropina.calcularTotal(monto, porcentaje);
Console.WriteLine($"Gracias, el monto inicial es de {monto}, con tu aporte del {porcentaje}%, el total es de {resultado}");

*/