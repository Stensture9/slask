while (true)
{
    Console.WriteLine("gissa vad jag tänker på");
    string? strong = Console.ReadLine();
    switch(strong)
    {
        case "Fiske":
            {
                Console.WriteLine("Rätt");
                Environment.Exit(0);
            }
        break;

        case "x":
            {
                Console.WriteLine("Hejdå");
                Environment.Exit(0);
            }
        break;

        default:
            {
                Console.WriteLine("Fel");
            }
        break;
    }
continue;
}