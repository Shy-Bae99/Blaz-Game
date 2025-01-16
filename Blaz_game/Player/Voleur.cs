namespace Player
{
    // Classe Voleur héritant de Joueur
    public class Voleur : Joueur
    {
        public Voleur()
        {
            this.Modifier(0, -25, +45, +10); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

        
    }
}