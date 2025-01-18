public static partial class DamageMessages
{
    private static readonly Random random = new Random();

    private static List<string> messages = new List<string>
    {
        "{0} frappe violemment {1}, infligeant {2} points de dégâts !",
        "{0} attaque avec puissance et inflige {2} dégâts à {1} !",
        "{0} touche {1} et réduit sa santé de {2} points.",
        "{0} ne montre aucune pitié et inflige {2} dégâts à {1} !"
    };

    public static string GetRandomMessage(string attacker, string defender, int damage)
    {
        string messageTemplate = messages[random.Next(messages.Count)];
        return string.Format(messageTemplate, attacker, defender, damage);
    }
}
