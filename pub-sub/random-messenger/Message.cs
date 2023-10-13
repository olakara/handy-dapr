namespace RandomMessenger;

public class Message
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public string Data { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Data} - {Time}";
    }
}