using Dapr.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDaprClient(clientBuilder =>
{
});

var app = builder.Build();

app.MapGet("/", () => "Caller Service running...");

app.MapGet("/call", async (DaprClient client) =>
{
    var request = client.CreateInvokeMethodRequest(HttpMethod.Get, "lookups", "say");
    var result = await client.InvokeMethodWithResponseAsync(request);
    if(result.IsSuccessStatusCode)
    {
        
        var data = await result.Content.ReadFromJsonAsync<Data>();
        return data.Message?? "Empty!";
    }
    else return result.StatusCode.ToString();
    
});

app.Run();

internal class Data
{
    public Data()
    {
        
    }
    public string Message { get; set; }
}