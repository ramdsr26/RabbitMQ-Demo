using RabbitMQ.Client;
using System.Text;

Console.WriteLine("Hello, World");

var factory = new ConnectionFactory()
{
    HostName = "localhost", 
    Port = 5672,
    UserName = "guest",     
    Password = "guest"
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

string exchangeName = "";
string routingKey = "TestQueue"; 

while (true)
{
    Console.WriteLine("Enter your message (or type 'exit' to quit):");
    string message = Console.ReadLine();

    if (string.Equals(message, "exit", StringComparison.OrdinalIgnoreCase))
        break;

    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(
        exchange: exchangeName,
        routingKey: routingKey,
        basicProperties: null,
        body: body
    );

    Console.WriteLine($" Sent message at Route '{routingKey}':'{message}'");
}