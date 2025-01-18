namespace Enemy
{
    // Classe Slime héritant de Ennemi
    public class Slime : Ennemi
    {
        public Slime()
        {
            this.Modifier(0, 0,0, 0, +50); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

    }
}