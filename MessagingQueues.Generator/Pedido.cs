using MessagingQueues.Entities;

namespace MessagingQueues.Generator
{
    public class Pedido
    {
        public static PedidoRequest GeneratePedido()
        {
            var pedido = new PedidoRequest();
            pedido.NumeroDoPedido = "1234";

            return pedido;
        }
    }
}
