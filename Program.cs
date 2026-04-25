using PedidosDeRestaurante.Logica;

List<Pedido> pedidos = new List<Pedido>();

Console.WriteLine("Introduzca el número de pedidos que desea realizar: ");
int.TryParse(Console.ReadLine(), out int n_pedidos);

int n_vueltas = 0;
while(n_vueltas < n_pedidos)
{ 
    // IMPORTANTÍSIMO: Crear el objeto DENTRO del bucle
    Pedido pedido = new Pedido();

    Console.WriteLine($"\n--- Pedido #{n_vueltas + 1} ---");
    
    Console.WriteLine("Nombre del plato: ");
    pedido.NombrePlato = Console.ReadLine();

    Console.WriteLine("Precio del plato: ");
    // Nota: TryParse no lanza excepciones, así que el try-catch aquí no haría falta,
    // pero si usas decimal.Parse() sí es necesario.
    if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
    {
        Console.WriteLine("Formato no válido, se asigna 10.00");
        precio = 10.0m;
    }
    pedido.Precio = precio;

    Console.WriteLine("Categoría (0-Entrada, 1-Principal, 2-Postre): ");
    int.TryParse(Console.ReadLine(), out int cat);
    
    // Aquí la parte que te faltaba: Asignación con Casting
    pedido.Categoria = (TipoPlato)cat;

    // guardar en la lista
    pedidos.Add(pedido);

    n_vueltas++; 
}

// RECORRER LA LISTA
Console.WriteLine("\nLISTA FINALIZADA:");
foreach (var p in pedidos)
{
    Console.WriteLine($"- {p.NombrePlato} ({p.Categoria}): ${p.Precio}");
}