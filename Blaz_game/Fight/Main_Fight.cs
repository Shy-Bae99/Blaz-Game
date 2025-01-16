class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int AttackSpeed { get; set; }
    public int Agility { get; set; }
    public int Armor { get; set; }

    public Character(string name, int health, int attack, int attackSpeed, int agility, int armor)
    {
        Name = name;
        Health = health;
        Attack = attack;
        AttackSpeed = attackSpeed;
        Agility = agility;
        Armor = armor;
    }
}

class Combat
{
    private static Random random = new Random();

    public static void Start(Character character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} vs {character2.Name} - Le combat commence !\n");

        while (character1.Health > 0 && character2.Health > 0)
        {
            FightTurn(character1, character2);
            if (character2.Health > 0)
            {
                FightTurn(character2, character1);
            }
        }

        string winner = character1.Health > 0 ? character1.Name : character2.Name;
        Console.WriteLine($"{winner} remporte le combat !\n");
    }

    private static void FightTurn(Character attacker, Character defender)
    {
        // Calcul de l'esquive
        int evadeChance = Math.Max(0, 100 - defender.Agility + attacker.AttackSpeed);
        bool isHit = random.Next(100) < evadeChance;

        if (isHit)
        {
            // Calcul des dégâts réduits par l'armure
            int damage = attacker.Attack - (attacker.Attack * defender.Armor / 100);
            damage = Math.Max(damage, 0);
            defender.Health -= damage;

            // Afficher un message de dégât aléatoire
            string damageMessage = DamageMessages.GetRandomMessage(attacker.Name, defender.Name, damage);
            Console.WriteLine(damageMessage);

            if (defender.Health <= 0)
            {
                Console.WriteLine($"{defender.Name} est vaincu !\n");
            }
        }
        else
        {
            Console.WriteLine($"{defender.Name} esquive l'attaque de {attacker.Name} !\n");
        }
    }
}