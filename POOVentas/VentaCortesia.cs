namespace POOVentas
{
    internal class VentaCortesia : Ventas
    {
        public override decimal CalcularTotal()
        {
            return 0; // Cuando sea venta cortesia, no se tiene que pagar nd.
        }
    }
}
