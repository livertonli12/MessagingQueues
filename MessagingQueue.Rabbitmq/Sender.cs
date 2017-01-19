using MessagingQueues.Generator;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingQueue.Rabbitmq
{
    public class Sender
    {
        public void Enqueue(string connectionString)
        {
            var factory = new ConnectionFactory() { HostName = "connectionString" };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "pedidos", durable: true, exclusive: false, autoDelete: false, arguments: null);

                    string pedido = JsonConvert.SerializeObject(Pedido.GeneratePedido());

                    channel.BasicPublish()
                }
            }
        }
    }
}
