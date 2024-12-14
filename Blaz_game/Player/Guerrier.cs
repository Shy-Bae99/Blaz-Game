namespace Player
{
    // Classe Guerrier héritant de Joueur
    public class Guerrier : Joueur
    {
        public Guerrier()
        {
            this.Modifier(0, -50, +25, +20); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

        public override void AfficherStatistiques()
        {
            Console.WriteLine("Classe: Guerrier");
            base.AfficherStatistiques();
        }
    }
}