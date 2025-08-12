using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory()
{
    HostName = "localhost",
    UserName = "guest",
    Password = "guest"
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "TestQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

string exchangeName = "";
string routingKey = "TestQueue";

Console.WriteLine($"[*] Waiting for messages with routing key '{routingKey}'...");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" Message Received: {message}");
};

channel.BasicConsume(queue: "TestQueue", autoAck: true, consumer: consumer);

Console.WriteLine("Press [Enter] to exit.");
Console.ReadLine();