namespace Loot;

public class LootGenerator
{
    // Define loot rarity chances
    private static Dictionary<string, int> RarityChances = new Dictionary<string, int>
    {
        { "Common", 70 }, // 70% chance
        { "Rare", 20 },   // 20% chance
        { "Epic", 8 },    // 8% chance
        { "Legendary", 2 } // 2% chance
    };

    // Define loot tables for each rarity

    //(pv,armure,attaque,vitesse attaque,agilité)
    private static Dictionary<string, List<LootItem>> LootTables = new Dictionary<string, List<LootItem>>
    {
        {
            "Common", new List<LootItem>
            {
                new LootItem("PotionHeal", new int[] { 5, 0, 0, 0, 0 }, 50),
                new LootItem("WoodArmor", new int[] { 0, 15, 0, 0, -20 }, 30),
                new LootItem("SmallSword", new int[] { 0, 0, 15, 0, -5 }, 20)
            }
        },
        {
            "Rare", new List<LootItem>
            {
                new LootItem("MediumPotionHeal", new int[] { 15, 0, 0, 0, 0 }, 40),
                new LootItem("IronArmor", new int[] { 0, 50, 0, 0, -50 }, 60)
            }
        },
        {
            "Epic", new List<LootItem>
            {
                new LootItem("EpicSword", new int[] { 0, 0, 25, 10, -5 }, 50),
                new LootItem("NetheriteArmor", new int[] { 0, 55, 0, 0, -30 }, 50)
            }
        },
        {
            "Legendary", new List<LootItem>
            {
                new LootItem("Excalibur", new int[] { 0, 0, 50, 10, 0 }, 100)
            }
        }
    };

    private static Random random = new Random();

    public static LootItem GenerateLoot()
    {
        // Step 1: Determine rarity
        string rarity = GetRandomRarity();

        // Step 2: Get item from selected rarity
        LootItem item = GetRandomItemFromRarity(rarity);

        // Return the loot item
        return item;
    }

    private static string GetRandomRarity()
    {
        int totalWeight = 0;
        foreach (var weight in RarityChances.Values)
        {
            totalWeight += weight;
        }

        int roll = random.Next(0, totalWeight);
        int cumulative = 0;

        foreach (var kvp in RarityChances)
        {
            cumulative += kvp.Value;
            if (roll < cumulative)
            {
                return kvp.Key;
            }
        }

        return "Common"; // Default
    }

    private static LootItem GetRandomItemFromRarity(string rarity)
    {
        List<LootItem> items = LootTables[rarity];

        int totalWeight = 0;
        foreach (var item in items)
        {
            totalWeight += item.DropChance;
        }

        int roll = random.Next(0, totalWeight);
        int cumulative = 0;

        foreach (var item in items)
        {
            cumulative += item.DropChance;
            if (roll < cumulative)
            {
                return item;
            }
        }

        return null; // (should never happen)
    }
}

public class LootItem
{
    public string Name { get; set; }
    public int[] Stats { get; set; } // Example: { +5, 0, 0, 0, 0 }
    public int DropChance { get; set; } // Weight for this item

    public LootItem(string name, int[] stats, int dropChance)
    {
        Name = name;
        Stats = stats;
        DropChance = dropChance;
    }

    public override string ToString()
    {
        return $"Item: {Name}, Stats: [{string.Join(", ", Stats)}]";
    }
}

// Example usage

//LootItem loot = LootGenerator.GenerateLoot();
//Console.WriteLine(loot);
    

