using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost"};
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();
