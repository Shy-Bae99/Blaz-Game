namespace Enemy
{
    // Classe Goblin héritant de Ennemi
    public class Goblin : Ennemi
    {
        public Goblin()
        {
            this.Modifier(+20, 0,0, +15, +15); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }
        
    }
}