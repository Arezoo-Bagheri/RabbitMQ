﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMqSamples.Domain.Entities;
using RabbitMqSamples.Toolkit;

namespace RabbitMqSamples.PubSub.Sub
{
    public class Program
    {

        public static ConnectionFactory _connectionFactory;
        public static IConnection _connection;
        public static IModel _model;
        public static string QueueName;
        private const string ExchangeName = "MyPaymentServiceExchange";

        public static void Main()
        {
            CreateConnection();

            var consumer = new EventingBasicConsumer(_model);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var payment = body.FromByteArray<Payment>();
                Console.WriteLine($" [x] Received {payment.FirstName} {payment.LastName} {payment.Value}");
            };

            _model.BasicConsume(queue: QueueName,
                                 autoAck: true,
                                 consumer: consumer);

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }

        public static void CreateConnection()
        {
            _connectionFactory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                Port = Protocols.DefaultProtocol.DefaultPort
            };

            _connection = _connectionFactory.CreateConnection();
            _model = _connection.CreateModel();
            QueueName = _model.QueueDeclare().QueueName;
            _model.QueueBind(QueueName, ExchangeName, "");

        }

    }
}
