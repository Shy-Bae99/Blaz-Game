using Player;
using Microsoft.JSInterop;


namespace Blaz_game.Services
{
    public class JoueurStateService
    {
        public Joueur JoueurActuel { get; private set; }

        public JoueurStateService()
        {
            JoueurActuel = new Joueur(); // Personnage par défaut
        }

        public void ModifierStats(int pvDelta, int attaqueDelta, int vitesseAttaqueDelta, int agiliteDelta, int armureDelta)
        {
            if (JoueurActuel != null)
            {
                ModifierStats(pvDelta, attaqueDelta, vitesseAttaqueDelta, agiliteDelta, armureDelta);
            }
        }

        public void SetJoueur(Joueur joueur)
        {
            JoueurActuel = joueur;
        }
    }
    
   
    public class CombatService
    {
        public string GetCombatMessage(string attacker, string defender, int damage)
        {
            return DamageMessages.GetRandomMessage(attacker, defender, damage);
        }
    }

}
