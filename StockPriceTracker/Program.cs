using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class StockPriceTracker
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to the Stock Price Tracker!");

        while (true)
        {
            Console.Write("Enter the stock ticker symbol (e.g., AAPL, MSFT): ");
            string symbol = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(symbol))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            string apiKey = "";  // Replace with your actual API key
            string apiUrl = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={symbol}&apikey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(apiUrl);
                    JObject json = JObject.Parse(response);
                    var globalQuote = json["Global Quote"];

                    if (globalQuote != null && globalQuote["05. price"] != null)
                    {
                        string price = globalQuote["05. price"].ToString();
                        string changePercent = globalQuote["10. change percent"]?.ToString();

                        Console.WriteLine($"Current price for {symbol}: {price} USD");
                        Console.WriteLine($"Change percentage: {changePercent}");
                    }
                    else
                    {
                        Console.WriteLine($"No data available for the symbol '{symbol}'. Please check if the symbol is correct.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.Write("Do you want to check another stock? (y/n): ");
            string continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for using the Stock Price Tracker!");
    }
}
