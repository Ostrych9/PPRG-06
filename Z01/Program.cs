

//Zadanie 1


string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("====================");
    Console.WriteLine($"Bohater: {heroName}");
    Console.WriteLine($"Zdrowie: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.WriteLine("====================");
    Console.WriteLine("1. Atak treningowy");
    Console.WriteLine("2. Odpoczynek");
    Console.WriteLine("3. Koniec gry");
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




void ShowMessage(string text)
{
    Console.WriteLine(text);
}

int AddGold(int gold, int reward)
{
    return gold + reward;
}

bool HasEnoughGold(int gold, int price) => gold >= price;


ShowMessage("Brawo!");

AddGold(20, 15);

if (HasEnoughGold(35, 25))
{
    Console.WriteLine("Masz wystarczająco złota, aby kupić przedmiot.");
}
else
{
    Console.WriteLine("Nie masz wystarczająco złota, aby kupić przedmiot.");
}

//Która metoda nie zwraca wartości?  ShowMessage
//Jakiego typu wynik zwraca HasEnoughGold?  true/false
//Co jest argumentem w wywołaniu AddGold(10, 5)?  10 i 5
//Gdzie można użyć wyniku HasEnoughGold(10, 8)?  W warunku if, można np. sprawdzić czy gracz może kupić jakiś przedmiot.