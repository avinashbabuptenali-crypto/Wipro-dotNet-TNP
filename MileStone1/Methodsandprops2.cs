using System;

class Stock
{
       string stockName;
    string stockSymbol;
    double previousClosingPrice;
    double currentClosingPrice;

       public Stock(string name, string symbol, double previousPrice, double currentPrice)
    {
        stockName = name;
        stockSymbol = symbol;
        previousClosingPrice = previousPrice;
        currentClosingPrice = currentPrice;
    }

       public double GetChangePercentage()
    {
        return ((currentClosingPrice - previousClosingPrice) / previousClosingPrice) * 100;
    }

    public void Display()
    {
        Console.WriteLine("\nStock Details");
        Console.WriteLine("----------------------");
        Console.WriteLine("Stock Name            : " + stockName);
        Console.WriteLine("Stock Symbol          : " + stockSymbol);
        Console.WriteLine("Previous Close Price  : " + previousClosingPrice);
        Console.WriteLine("Current Close Price   : " + currentClosingPrice);
        Console.WriteLine("Change Percentage     : " + GetChangePercentage() + "%");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine();

        Console.Write("Enter Previous Closing Price: ");
        double previousPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Current Closing Price: ");
        double currentPrice = Convert.ToDouble(Console.ReadLine());

        Stock stock = new Stock(name, symbol, previousPrice, currentPrice);

        stock.Display();
    }
}