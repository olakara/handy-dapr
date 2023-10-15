using System;
using Dapr.Client;

namespace RandomMessenger 
{
    internal class Program
    {
        private const string PUBSUB_NAME = "pubsub";
        private const string TOPIC_NAME = "stars";

        static async Task Main(string[] args)
        {
            while (true)
            {
                var t = Task.Run(async delegate { await Task.Delay(TimeSpan.FromSeconds(5)); });
                t.Wait();
                var message = MessageGenerator.GetMessage();
                Console.WriteLine(message);
                var source = new CancellationTokenSource();
                var cancellationToken = source.Token;
                using var client = new DaprClientBuilder().Build();
                await client.PublishEventAsync(PUBSUB_NAME, TOPIC_NAME, message, cancellationToken);

            }
        }
    }
}