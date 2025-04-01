// Screen Sound

string messageWelcome = "Welcome to the Screen Sound!";

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
            Console.WriteLine("Você selecionou a opção:" + optionSelected);
            break;
        case 2:
            Console.WriteLine("Você selecionou a opção:" + optionSelected);
            break;
        case 3:
            Console.WriteLine("Você selecionou a opção:" + optionSelected);
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

ShowMessageWelcome();
ShowMenuOptions();