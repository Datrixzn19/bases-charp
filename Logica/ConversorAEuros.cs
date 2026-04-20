namespace ConversorAEuros.Logica;

public class Conversor
{
    public decimal ConvertirAEuros(decimal monto)
    {
        //cada dolar equivale a 0.85 euros
        //decimal resultado = monto*8.84m;
        return monto*0.85m;
    }
}


/*

using ConversorAEuros.Logica;


Console.WriteLine("Conversor de dolares a euros");
Console.WriteLine("Ingrese la cantidad de dolares a convertir: ");

//
decimal monto;
while (!decimal.TryParse(Console.ReadLine(), out monto))//devuelve un boleano y el resultado
{
    Console.WriteLine("Por favor ingresa una cantidad valida ej 8.99");
}


var conversor = new Conversor();

decimal resultado = conversor.ConvertirAEuros(monto);
Console.WriteLine($"El resultado es {resultado:C2}");//vscode no me reecnoce el c2 nose porque 
*/