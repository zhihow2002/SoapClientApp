using System.Text.Json;
using ServiceReference;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new BlacklistServiceClient();

        client.ClientCredentials.UserName.UserName = "commonws";
        client.ClientCredentials.UserName.Password = "password";

        var request = new BlacklistClientValRequest
        {
            name = "Zulkifli Bin OMAR",
            nric = "690423115143",
            trxId = "WS_TEST_UAT"
        };

        var response = await client.BlacklistClientValidateAsync(request);

        string requestJson = JsonSerializer.Serialize(request);
        string responseJson = JsonSerializer.Serialize(response);

        using (var context = new LoggingContext())
        {
            context.Logs.Add(
                new LogEntry
                {
                    Request = requestJson,
                    Response = responseJson,
                    Timestamp = DateTime.Now
                }
            );
            context.SaveChanges();
        }

        Console.WriteLine("Logged SOAP request and response.");
    }
}
