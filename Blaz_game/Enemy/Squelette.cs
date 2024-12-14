namespace Enemy
{
    // Classe Barbare héritant de Ennemi
    public class Squelette : Ennemi
    {
        public Squelette()
        {
            this.Modifier(-10, +20, +20, 0); // Mise a jour des stats (vie, vitesse d'attaque, agilité et armure)
        }

        public override void AfficherStatistiques()
        {
            Console.WriteLine("Classe: Squelette");
            base.AfficherStatistiques();
        }
    }
}