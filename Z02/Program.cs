

//Zadanie 2


string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

while (isRunning)
{
    ShowPanelTitle("Status bohatera", ConsoleColor.DarkBlue);
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    Console.Write("Wybór: ");

    string? command = Console.ReadLine();

    if (command == "1")
    {
        int damage = strength + weaponDamage;
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health += 10;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else if (command == "3")
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Nieznana komenda.");
    }
}


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
    Console.WriteLine($"{health}/{maxHealth} HP");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Złoto:    ");
    Console.ResetColor();
    Console.WriteLine(gold);
}

void ShowMenu()
{
    ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
    Console.WriteLine("[1] Atak treningowy");
    Console.WriteLine("[2] Odpoczynek");
    Console.WriteLine("[3] Koniec gry");
}