using System;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        GetData();
    }

    public static async void GetData()
    {
        Console.WriteLine("Fetching data...");

        await Task.Delay(3000);

        Console.WriteLine("Data received");
    }
}