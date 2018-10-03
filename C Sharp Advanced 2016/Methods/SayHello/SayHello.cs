using System;

class SayHello
{
    static void GreetName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        GreetName(name);
    }
}
