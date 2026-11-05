

//Zadanie 5


string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;


while (!IsGameOver(health))
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
        Console.WriteLine("Koniec gry!");
        break;
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
//Skrócenie funkcji ShowMenu nie ma sensu, ponieważ ta funkcja jest odpowiedzialna za wyświetlanie paru linijek tekstu i nie można jej zapisać w jednej linii, bo byłoby to mniej czytelne.

int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;
//Skrócenie funkcji CalculateDamage ma sens, ponieważ ta funkcja jest bardzo prosta i można ją zapisać w jednej linii.

int Heal(int health, int amount, int maxHealth) => Math.Min(health + amount, maxHealth);
//Skrócenie funkcji Heal ma sens, ponieważ ta funkcja jest bardzo prosta i można ją zapisać w jednej linii. Użycie Math.Min pozwala na uniknięcie dodatkowego warunku if.

bool IsGameOver(int health)
{
    if (health <= 0)
    {
        Console.WriteLine("Koniec gry!");
        return true;
    }
    else
    {
        return false;
    }
}
//Skrócenie funkcji IsGameOver nie ma sensu, ponieważ ta funkcja zawiera opcje komunikatu o końcu gry, która jest kluczowa dla kodu.
