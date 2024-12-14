namespace Player
{
    // Classe Barbare héritant de Joueur
    public class Barbare : Joueur
    {
        public Barbare()
        {
            this.Modifier(0, -80, +10, +30); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

        public override void AfficherStatistiques()
        {
            Console.WriteLine("Classe: Barbare");
            base.AfficherStatistiques();
        }
    }
}