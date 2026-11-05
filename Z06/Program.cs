

//Zadanie 6


bool isRunning = true;
int health = 70;
int maxHealth = 100;
string heroName = "Ada";
int gold = 10;
int strength = 6;
int weaponDamage = 3;


while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    string command = ReadCommand();

    if (command == "1")
    {
        int damage = CalculateDamage(strength, weaponDamage);
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        Console.WriteLine($"Odpoczywasz. Masz teraz {Heal(health, 10, maxHealth)}/{maxHealth} HP.");
    }
    else
    {
        isRunning = false;
    }
}


int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;
int Heal(int health, int amount, int maxHealth) => Math.Min(health + amount, maxHealth);

void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"  {title.ToUpper()}  ");
    Console.ResetColor();
}

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    ShowPanelTitle("Status bohatera", ConsoleColor.DarkBlue);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Bohater:  ");
    Console.ResetColor();
    Console.WriteLine(name);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Zdrowie: ");
    Console.ResetColor();
    Console.WriteLine($"{Heal(health, 10, maxHealth)}/{maxHealth} HP");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Złoto:    ");
    Console.ResetColor();
    Console.WriteLine(gold);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Obrażenia: ");
    Console.ResetColor();
    Console.WriteLine(CalculateDamage(strength, weaponDamage));

}

void ShowMenu()
{
    ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
    Console.WriteLine("[1] Atak treningowy");
    Console.WriteLine("[2] Odpoczynek");
    Console.WriteLine("[3] Koniec gry");
}

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
