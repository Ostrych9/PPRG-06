

//Zadanie 4


ReadCommand();

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór: ");
        string command = Console.ReadLine();

        if (command == "1" || command == "2" || command == "3")
        {
            Console.WriteLine($"Wybrałeś poprawną komendę: {command}");
            return command;
        }
        else
        {
            Console.WriteLine($"Nieznana komenda: {command}");
        }
    }           
}           


