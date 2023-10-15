namespace listener;

public class Message
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public string Data { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Id} - {Data} - {Time}";
    }
}