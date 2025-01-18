namespace Enemy
{
    // Classe Squelette héritant de Ennemi
    public class Squelette : Ennemi
    {
        public Squelette()
        {
            this.Modifier(-10, 0,+20, +20, 0); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

    }
}