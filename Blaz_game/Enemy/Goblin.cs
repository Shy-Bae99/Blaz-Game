namespace Enemy
{
    // Classe Barbare héritant de Ennemi
    public class Goblin : Ennemi
    {
        public Goblin()
        {
            this.Modifier(+20, 0, +15, +15); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

        public override void AfficherStatistiques()
        {
            Console.WriteLine("Classe: Goblin");
            base.AfficherStatistiques();
        }
    }
}