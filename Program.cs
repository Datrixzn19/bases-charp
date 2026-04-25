using PedidosDeRestaurante.Logica;

List<Pedido> pedidos = new List<Pedido>();

Console.WriteLine("Introduzca el número de pedidos que desea realizar: ");
int.TryParse(Console.ReadLine(), out int n_pedidos);

int n_vueltas = 0;
while(n_vueltas < n_pedidos)
{ 
    // Crear el obj dentro del bucle 
    Pedido pedido = new Pedido();

    Console.WriteLine($"\nPedido #{n_vueltas + 1}");

        //NOMBRE
    Console.WriteLine("Nombre del plato: ");
    pedido.NombrePlato = Console.ReadLine();

        //PRECIO
    Console.WriteLine("Precio del plato: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
    {
        Console.WriteLine("Formato no válido, se asigna 10.00");
        precio = 10.0m;
    }
    pedido.Precio = precio;

        //CATEGORIA
    Console.WriteLine("Categoría (0-Entrada, 1-Principal, 2-Postre): ");
    int.TryParse(Console.ReadLine(), out int cat);
    

    pedido.Categoria = (TipoPlato)cat;
    pedidos.Add(pedido);

    n_vueltas++; 
}

// RECORRER LA LISTA
Console.WriteLine("\nLISTA FINALIZADA:");
foreach (var p in pedidos)
{
    Console.WriteLine($"- {p.NombrePlato} ({p.Categoria}): ${p.Precio}");
}