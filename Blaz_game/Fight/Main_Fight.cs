using Player;
using Enemy;
using System;
using System.Collections.Generic;

public class Character
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


public class Combat
{
    private static Random random = new Random();
    private List<string> combatLog = new List<string>(); // Pour stocker les messages

    public List<string> CombatLog => combatLog; // Expose les messages pour l'UI

    public Character Start(Character character1, Character character2)
    {
        combatLog.Clear(); // Nettoie les messages pour un nouveau combat
        combatLog.Add($"{character1.Name} vs {character2.Name} - Le combat commence !");
        
        while (character1.Health > 0 && character2.Health > 0)
        {
            FightTurn(character1, character2);
            if (character2.Health > 0)
            {
                FightTurn(character2, character1);
            }
        }

        Character winner = character1.Health > 0 ? character1 : character2;
        combatLog.Add($"{winner.Name} remporte le combat !");
        return winner;
    }

    private void FightTurn(Character attacker, Character defender)
    {
        int evadeChance = Math.Max(0, 100 - defender.Agility + attacker.AttackSpeed);
        bool isHit = random.Next(100) < evadeChance;

        if (isHit)
        {
            int damage = attacker.Attack - (attacker.Attack * defender.Armor / 100);
            damage = Math.Max(damage, 0);
            defender.Health -= damage;

            string combatMessage = DamageMessages.GetRandomMessage(attacker.Name, defender.Name, damage);
            combatLog.Add(combatMessage);

            if (defender.Health <= 0)
            {
                combatLog.Add($"{defender.Name} est vaincu !");
            }
        }
        else
        {
            combatLog.Add($"{defender.Name} esquive l'attaque de {attacker.Name} !");
        }
    }
}

// Modifications pour correspondre aux changements suggérés
public class Joueur
{
    public int Pv { get; set; } = 100;
    public int Attaque { get; set; } = 20;
    public int VitesseAttaque { get; set; } = 10;
    public int Agilite { get; set; } = 15;
    public int Armure { get; set; } = 5;

    public Character ToCharacter()
    {
        return new Character("Joueur", Pv, Attaque, VitesseAttaque, Agilite, Armure);
    }
}

public class Ennemi
{
    public int Pv { get; set; } = 80;
    public int Attaque { get; set; } = 15;
    public int VitesseAttaque { get; set; } = 8;
    public int Agilite { get; set; } = 10;
    public int Armure { get; set; } = 3;

    public Character ToCharacter()
    {
        return new Character("Monstre", Pv, Attaque, VitesseAttaque, Agilite, Armure);
    }
}

partial class Program
{
    static void Main(string[] args)
    {
        Joueur joueur = new Joueur();
        Ennemi ennemi = new Ennemi();

        // Utilisation des méthodes ToCharacter pour créer des objets Character
        Character hero = joueur.ToCharacter();
        Character monster = ennemi.ToCharacter();

        Combat combat = new Combat();
        Character winner = combat.Start(hero, monster);

        // Afficher les logs du combat
        foreach (var message in combat.CombatLog)
        {
            Console.WriteLine(message);
        }
    }
    
}

