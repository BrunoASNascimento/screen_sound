// Screen Sound

string messageWelcome = "Welcome to the Screen Sound!";
//List<string> bands = new List<string>();
// List<string> bands = new List<string> { "U2", "Kiss", "Ozzy" };

Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>(StringComparer.InvariantCultureIgnoreCase)
{
    { "U2", new List<int>() { 10, 9, 8 } },
    { "Kiss", new List<int>() },
    { "Ozzy", new List<int>() { 10, 10, 10, 8, 9 } }
};

void ShowMessageWelcome()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(messageWelcome);
}

void ShowMenuOptions()
{
    ShowMessageWelcome();
    Console.WriteLine("1 - Register Band");
    Console.WriteLine("2 - List Bands");
    Console.WriteLine("3 - Evaluate Band");
    Console.WriteLine("4 - Calculate average of the Band");
    Console.WriteLine("0 - Exit");

    Console.Write("\nDigite sua opção: ");
    string optionSelected = Console.ReadLine()!;
    int optionSelectedInt = int.Parse(optionSelected);

    switch (optionSelectedInt)
    {
        case 1:
            RegisterBand();

            break;
        case 2:
            ShowAllBands();
            break;
        case 3:
            EvaluateBand();
            break;
        case 4:
            Console.WriteLine("Você selecionou a opção:" + optionSelected);
            break;
        case 0:
            Console.WriteLine("Até a próxima!");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void RegisterBand()
{
    ShowTitle("Register Band");
    Console.Write("Write the name of band:");
    string bandName = Console.ReadLine()!;


    if (!bands.ContainsKey(bandName))
    {
        bands.Add(bandName, new List<int>());
    }

    Console.Write($"The band {bandName} was registered");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowAllBands()
{
    ShowTitle("Bands list");
    //for (int i = 0; i < bands.Count; i++)
    //{
    //    Console.WriteLine($"Band: {bands[i]}");
    //}
    foreach (string band in bands.Keys)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

void ShowTitle(string title)
{
    int sizeOfTitle = title.Length;
    string detailTitle = string.Empty.PadLeft(sizeOfTitle, '*');


    Console.Clear();
    Console.WriteLine(detailTitle);
    Console.WriteLine(title);
    Console.WriteLine(detailTitle);
    Console.WriteLine();
}

void EvaluateBand()
{
}

ShowMenuOptions();