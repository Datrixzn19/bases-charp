namespace PedidosDeRestaurante.Logica;

// Definimos el Enum para el tipo de plato
public enum TipoPlato 
{
    Entrada,    // 0
    Principal,  // 1
    Postre      // 2
}

public class Pedido
{
    public string NombrePlato { get; set; }
    public decimal Precio { get; set; }
    public TipoPlato Categoria { get; set; } //es del tipo de dato TipoPlato(es el enum)
}