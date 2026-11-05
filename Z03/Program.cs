

//Zadanie 3


int strength = 0;
int weaponDamage = 4;
int health = 50;
int amount = -60;
int maxHealth = 100;

int damage = CalculateDamage(strength, weaponDamage);
health = Heal(health, amount, maxHealth);

while(!IsGameOver(health))
{
    Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    Console.WriteLine($"Masz teraz {health}/{maxHealth} HP.");
    break;
}





int CalculateDamage(int strength, int weaponDamage)
{
    return strength + weaponDamage;
}

int Heal(int health, int amount, int maxHealth)
{
    health += amount;

    if (health > maxHealth)
    {
        health = maxHealth;
    }

    return health;
}

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