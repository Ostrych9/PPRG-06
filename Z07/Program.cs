

//Zadanie 7


int health = 5;
int Heal(int health, int amount) => health + amount;
health = Heal(health, 10);


if (health < 20)
{
    string warning = "Mało zdrowia!";
    Console.WriteLine(warning);
}


CalculateDamage(5, 3);

int CalculateDamage(int strength, int weaponDamage)
{
    Console.Write("Czy chcesz zaatakować? ");
    string? answer = Console.ReadLine();
    Console.WriteLine("Rozpoczynam animację ataku...");
    return strength + weaponDamage;
}