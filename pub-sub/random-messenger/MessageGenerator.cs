namespace RandomMessenger;

public static class MessageGenerator
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public static Message GetMessage()
    {
        var index = Random.Shared.Next(-20, 20);
        var position = Random.Shared.Next(1, 10);
        return new Message
        {
            Id = Guid.NewGuid(),
            Time = DateTime.Now.AddDays(index),
            Data = Summaries[position]
        };
    }
}