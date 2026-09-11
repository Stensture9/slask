namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Whats your name?");
        string name = Console.ReadLine();
        Console.WriteLine(DoSomething(""));
    }
    static string DoSomething (string name)
    {
        return $"Hello {name}";
    }
}
