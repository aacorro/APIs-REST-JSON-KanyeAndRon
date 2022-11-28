using APIs_JSON_KanyeAndRon;

var client = new HttpClient();

var quote = new QuoteGenerator(client);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Kanye: {quote.Kanye()}");
    Console.WriteLine($"Ron: {quote.Ron()}");

    Console.WriteLine("----------------------------------------------------");

}
