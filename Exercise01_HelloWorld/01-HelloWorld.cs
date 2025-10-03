using System;

class Program
{
    
    static string ShowMessage(string name)
    {
        return $"Hello, {name}!";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ShowMessage(args.Length > 0 ? args[0] : "Dani"));


        Console.WriteLine(ShowMessage(args.Length > 1 ? args[1] : "José"));
    }
}
